﻿
/* **********************************************************************
 *                   类【XmlUtility.cs】信息
 *                    
 * 所属项目：SM.BaseControls.util       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：XmlUtility
 * 功    能：Xml操作文件
 * 来    历：HUCSD 创建于 2013-08-13 10:54:43 
 * 
 * **********************************************************************/
using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.IO;
using System.Text;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml;

namespace SM.BaseControls 
{
    /// <summary>
    /// Xml操作类
    /// </summary>
    public class XmlUtility
    {
        #region 公共变量
        static XmlDocument xmldoc = new XmlDocument();
        static XmlNode xmlnode;
        static XmlElement xmlelem = null, root = null;
        #endregion
        public static string getSMSKey(string KeyTag)
        {
            string rtnstr = "";
            //string strXmlUrl=Server.MapPath("~/Xml/SMSConfig.xml");
            System.Xml.XmlTextReader xr = new System.Xml.XmlTextReader(System.Web.HttpContext.Current.Server.MapPath("~/App_Data/SMSConfig.xml"));
            xr.MoveToAttribute("Config");
            while (xr.Read())
            {
                if (xr.Name.Equals(KeyTag))
                {
                    rtnstr = xr.ReadElementString();
                    break;
                }
            }
            xr.Close();
            return rtnstr;
        }

        /// <summary>
        /// 绑定常量ddl id和name一样
        /// </summary>
        /// <param name="dropDownList"></param>
        /// <param name="defaultSelectItem"></param> 
        public static void InitXMLDropDownList(DropDownList dropDownList, string fileName, string defaultItem)
        {
            dropDownList.ClearSelection();
            //if (defaultItem != "") dropDownList.Items.Add(new ListItem(defaultItem, defaultItem));
            XmlDocument doc = new XmlDocument();
            XmlNodeReader reader = null;
            try
            {
                doc.Load(System.Web.HttpContext.Current.Server.MapPath("~/App_Data/" + fileName));
                reader = new XmlNodeReader(doc);
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Text)
                        dropDownList.Items.Add(new ListItem(reader.Value, reader.Value));

                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }




        }
        /// <summary>
        /// 返回可显示行数
        /// </summary>
        /// <param name="modKey"></param>
        /// <returns></returns>
        public static int GetNumFormConfig(string modKey)
        {
            return Int32.Parse(GetWebParam(modKey));
        }
        public static string GetWebParam(string modKey)
        {
            return  ConfigurationManager.AppSettings[modKey];
        }
        public static string GetConnFormConfig(string conn)
        {
            return ConfigurationManager.ConnectionStrings[conn].ConnectionString;
        }

        /// <summary>
        /// 读取配置串
        /// </summary>
        /// <param name="id">table的ID</param>
        /// <returns>返回字段列表的字符串，如： "filed0,filed1"</returns>
        /// 使用方法
        /// XMLBean xmlBean = new XMLBean();
        ///string str = xmlBean.ReadFiled("B02");
        public static string ReadFiled(string id)
        {
            string fildes = "";
            try
            {
                string fileName = "";
                if (XmlUtility.GetWebParam("ClientType") == "WebForm")
                    fileName = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/FieldsList.xml");
                else
                    fileName = Application.StartupPath + "\\App_Data\\FieldsList.xml";
                xmldoc.Load(fileName);
                root = xmldoc.DocumentElement;
                xmlelem = (XmlElement)root.SelectSingleNode("/tables/table[@id='" + id + "']");
                fildes = xmlelem.GetElementsByTagName("current").Item(0).InnerText.ToString();
            }
            catch (Exception e)
            {
                LogHelper.WriteLog("从配置文件获取要显示的字段出错。", e);
                //throw new Exception(e.Message);
            }
            return fildes;
        }


        #region 创建Xml文档
        /// <summary>
        /// 创建一个带有根节点的Xml文件
        /// </summary>
        /// <param name="FileName">Xml文件名称</param>
        /// <param name="rootName">根节点名称</param>
        /// <param name="Encode">编码方式:gb2312，UTF-8等常见的</param>
        /// <param name="DirPath">保存的目录路径</param>
        /// <returns></returns>
        public bool CreateXmlDocument(string FileName, string rootName, string Encode)
        {
            try
            {
                XmlDeclaration xmldecl;
                xmldecl = xmldoc.CreateXmlDeclaration("1.0", Encode, null);
                xmldoc.AppendChild(xmldecl);
                xmlelem = xmldoc.CreateElement("", rootName, "");
                xmldoc.AppendChild(xmlelem);
                xmldoc.Save(FileName);
                return true;
            }
            catch (Exception e)
            {
                return false;
                throw new Exception(e.Message);
            }
        }

        #endregion

        #region 常用操作方法(增删改)
        /// <summary>
        /// 插入一个节点和它的若干子节点
        /// </summary>
        /// <param name="XmlFile">Xml文件路径</param>
        /// <param name="NewNodeName">插入的节点名称</param>
        /// <param name="HasAttributes">此节点是否具有属性，True为有，False为无</param>
        /// <param name="fatherNode">此插入节点的父节点</param>
        /// <param name="htAtt">此节点的属性，Key为属性名，Value为属性值</param>
        /// <param name="htSubNode">子节点的属性，Key为Name,Value为InnerText</param>
        /// <returns>返回真为更新成功，否则失败</returns>
        public bool InsertNode(string XmlFile, string NewNodeName, bool HasAttributes, string fatherNode, Hashtable htAtt, Hashtable htSubNode)
        {
            try
            {

                xmldoc.Load(XmlFile);
                XmlNode root = xmldoc.SelectSingleNode(fatherNode);
                xmlelem = xmldoc.CreateElement(NewNodeName);

                if (htAtt != null && HasAttributes)//若此节点有属性，则先添加属性
                {
                    SetAttributes(xmlelem, htAtt);

                    SetNodes(xmlelem.Name, xmldoc, xmlelem, htSubNode);//添加完此节点属性后，再添加它的子节点和它们的InnerText

                }
                else
                {
                    SetNodes(xmlelem.Name, xmldoc, xmlelem, htSubNode);//若此节点无属性，那么直接添加它的子节点
                }

                root.AppendChild(xmlelem);
                xmldoc.Save(XmlFile);

                return true;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);

            }
        }
        /// <summary>
        /// 更新节点
        /// </summary>
        /// <param name="XmlFile">Xml文件路径</param>
        /// <param name="fatherNode">需要更新节点的上级节点</param>
        /// <param name="htAtt">需要更新的属性表，Key代表需要更新的属性，Value代表更新后的值</param>
        /// <param name="htSubNode">需要更新的子节点的属性表，Key代表需要更新的子节点名字Name,Value代表更新后的值InnerText</param>
        /// <returns>返回真为更新成功，否则失败</returns>
        public bool UpdateNode(string XmlFile, string fatherNode, Hashtable htAtt, Hashtable htSubNode)
        {
            try
            {

                xmldoc.Load(XmlFile);
                XmlNodeList root = xmldoc.SelectSingleNode(fatherNode).ChildNodes;
                UpdateNodes(root, htAtt, htSubNode);
                xmldoc.Save(XmlFile);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// 删除指定节点下的子节点
        /// </summary>
        /// <param name="XmlFile">Xml文件路径</param>
        /// <param name="fatherNode">制定节点</param>
        /// <returns>返回真为更新成功，否则失败</returns>
        public bool DeleteNodes(string XmlFile, string fatherNode)
        {
            try
            {

                xmldoc.Load(XmlFile);
                xmlnode = xmldoc.SelectSingleNode(fatherNode);
                xmlnode.RemoveAll();
                xmldoc.Save(XmlFile);
                return true;
            }
            catch (XmlException xe)
            {
                throw new XmlException(xe.Message);
            }
        }
        #endregion


        //将xml对象内容字符串转换为DataSet
        public static DataSet ConvertXMLToDataSet(string xmlData)
        {
            StringReader stream = null;
            XmlTextReader reader = null;
            try
            {
                DataSet xmlDS = new DataSet();
                stream = new StringReader(xmlData);
                //从stream装载到XmlTextReader
                reader = new XmlTextReader(stream);
                xmlDS.ReadXml(reader);
                return xmlDS;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (reader != null) reader.Close();
            }
        }

        //将xml文件转换为DataSet
        public static DataSet ConvertXMLFileToDataSet(string xmlFile)
        {
            StringReader stream = null;

            XmlTextReader reader = null;
            try
            {
                XmlDocument xmld = new XmlDocument();
                xmld.Load(xmlFile);

                DataSet xmlDS = new DataSet();
                stream = new StringReader(xmld.InnerXml);
                //从stream装载到XmlTextReader
                reader = new XmlTextReader(stream);
                xmlDS.ReadXml(reader);
                //xmlDS.ReadXml(xmlFile);
                return xmlDS;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (reader != null) reader.Close();
            }
        }

        //将DataSet转换为xml对象字符串
        public static string ConvertDataSetToXML(DataSet xmlDS)
        {
            MemoryStream stream = null;
            XmlTextWriter writer = null;

            try
            {
                stream = new MemoryStream();
                //从stream装载到XmlTextReader
                writer = new XmlTextWriter(stream, Encoding.Unicode);

                //用WriteXml方法写入文件.
                xmlDS.WriteXml(writer);
                int count = (int)stream.Length;
                byte[] arr = new byte[count];
                stream.Seek(0, SeekOrigin.Begin);
                stream.Read(arr, 0, count);

                UnicodeEncoding utf = new UnicodeEncoding();
                return utf.GetString(arr).Trim();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (writer != null) writer.Close();
            }
        }

        //将DataSet转换为xml文件
        public static void ConvertDataSetToXMLFile(DataSet xmlDS, string xmlFile)
        {
            MemoryStream stream = null;
            XmlTextWriter writer = null;

            try
            {
                stream = new MemoryStream();
                //从stream装载到XmlTextReader
                writer = new XmlTextWriter(stream, Encoding.Unicode);

                //用WriteXml方法写入文件.
                xmlDS.WriteXml(writer);
                int count = (int)stream.Length;
                byte[] arr = new byte[count];
                stream.Seek(0, SeekOrigin.Begin);
                stream.Read(arr, 0, count);

                //返回Unicode编码的文本
                UnicodeEncoding utf = new UnicodeEncoding();
                StreamWriter sw = new StreamWriter(xmlFile);
                sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                sw.WriteLine(utf.GetString(arr).Trim());
                sw.Close();


            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (writer != null) writer.Close();
            }
        }

        #region 私有方法
        /// <summary>
        /// 设置节点属性
        /// </summary>
        /// <param name="xe">节点所处的Element</param>
        /// <param name="htAttribute">节点属性，Key代表属性名称，Value代表属性值</param>
        private void SetAttributes(XmlElement xe, Hashtable htAttribute)
        {
            foreach (DictionaryEntry de in htAttribute)
            {
                xe.SetAttribute(de.Key.ToString(), de.Value.ToString());
            }
        }
        /// <summary>
        /// 增加子节点到根节点下
        /// </summary>
        /// <param name="rootNode">上级节点名称</param>
        /// <param name="XmlDoc">Xml文档</param>
        /// <param name="rootXe">父根节点所属的Element</param>
        /// <param name="SubNodes">子节点属性，Key为Name值，Value为InnerText值</param>
        private void SetNodes(string rootNode, XmlDocument XmlDoc, XmlElement rootXe, Hashtable SubNodes)
        {
            foreach (DictionaryEntry de in SubNodes)
            {
                xmlnode = XmlDoc.SelectSingleNode(rootNode);
                XmlElement subNode = XmlDoc.CreateElement(de.Key.ToString());
                subNode.InnerText = de.Value.ToString();
                rootXe.AppendChild(subNode);
            }
        }
        /// <summary>
        /// 更新节点属性和子节点InnerText值
        /// </summary>
        /// <param name="root">根节点名字</param>
        /// <param name="htAtt">需要更改的属性名称和值</param>
        /// <param name="htSubNode">需要更改InnerText的子节点名字和值</param>
        private void UpdateNodes(XmlNodeList root, Hashtable htAtt, Hashtable htSubNode)
        {
            foreach (XmlNode xn in root)
            {
                xmlelem = (XmlElement)xn;
                if (xmlelem.HasAttributes)//如果节点如属性，则先更改它的属性
                {
                    foreach (DictionaryEntry de in htAtt)//遍历属性哈希表
                    {
                        if (xmlelem.HasAttribute(de.Key.ToString()))//如果节点有需要更改的属性
                        {
                            xmlelem.SetAttribute(de.Key.ToString(), de.Value.ToString());//则把哈希表中相应的值Value赋给此属性Key
                        }
                    }
                }
                if (xmlelem.HasChildNodes)//如果有子节点，则修改其子节点的InnerText
                {
                    XmlNodeList xnl = xmlelem.ChildNodes;
                    foreach (XmlNode xn1 in xnl)
                    {
                        XmlElement xe = (XmlElement)xn1;
                        foreach (DictionaryEntry de in htSubNode)
                        {
                            if (xe.Name == de.Key.ToString())//htSubNode中的key存储了需要更改的节点名称，
                            {
                                xe.InnerText = de.Value.ToString();//htSubNode中的Value存储了Key节点更新后的数据
                            }
                        }
                    }
                }

            }
        }
        #endregion

    }
}

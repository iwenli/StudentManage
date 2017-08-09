
/* **********************************************************************
 *                   类【Serialize.cs】信息
 *                    
 * 所属项目：SM.Control       
 * 
 * 版    权：HUCSD @Copy Right 2008+
 * 联系ＱＱ：234486036
 * 
 * 名    称：Serialize
 * 功    能：常用操作
 * 来    历：HUCSD 创建于 2013-08-13 09:15:26 
 * 
 * **********************************************************************/
using System;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SM.BaseControls
{
    /// <summary>
    /// 序列化对象
    /// </summary>
    public class Serialize
    {
        /// <summary>
        /// 序列化为对象 用二进制格式序列化
        /// </summary>
        /// <param name="objname">存储的文件对象</param>
        /// <param name="obj">要序列话的对象</param>
        public static void BinarySerialize(string objname, object obj)
        {
            try
            {
                string filename = objname + ".SM";
                if (System.IO.File.Exists(filename))
                    System.IO.File.Delete(filename);
                using (FileStream fileStream = new FileStream(filename, FileMode.Create))
                {
                    // 用二进制格式序列化
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(fileStream, obj);
                    fileStream.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 从二进制文件中反序列化
        /// </summary>
        /// <param name="objname">存储文件对象</param>
        /// <returns>反序列化对象</returns>
        public static object BinaryDeserialize(string objname)
        {
            System.Runtime.Serialization.IFormatter formatter = new BinaryFormatter();
            //二进制格式反序列化
            object obj;
            string filename = objname + ".SM";
            if (!System.IO.File.Exists(filename))
                throw new Exception("在反序列化之前,请先序列化");
            using (Stream stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                obj = formatter.Deserialize(stream);
                stream.Close();
            }
            //using (FileStream fs = new FileStream(filename, FileMode.Open))
            //{
            //    BinaryFormatter formatter = new BinaryFormatter();
            //    object obj = formatter.Deserialize(fs);
            //}
            return obj;
        }
    }

    #region 调用示例
    //public class Demo
    //{
    //    public void DemoFunction()
    //    {
    //        //序列化
    //        Car car = new Car("chenlin", "120万");
    //        Serialize.BinarySerialize("Binary序列化", car);
    //        Serialize.SoapSerialize("Soap序列化", car);
    //        Serialize.XmlSerialize("XML序列化", car);
    //        //反序列化
    //        Car car2 = (Car)Serialize.BinaryDeserialize("Binary序列化");
    //        car2 = (Car)Serialize.SoapDeserialize("Soap序列化");
    //        car2 = (Car)Serialize.XmlDeserailize("XML序列化");
    //    }
    //}
    #endregion
}


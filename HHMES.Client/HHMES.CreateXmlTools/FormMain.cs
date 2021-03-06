﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Diagnostics;

namespace CreateXmlTools
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            txtWebUrl.Text = "localhost:8017";
            txtWebUrl.ForeColor = Color.Gray;
        }

        //获取当前目录
        //string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string currentDirectory = System.Environment.CurrentDirectory;
        //服务端xml文件名称
        string serverXmlName = "AutoupdateService.xml";
        //更新文件URL前缀
        string url = string.Empty;

        void CreateXml()
        {
            //创建文档对象
            XmlDocument doc = new XmlDocument();
            //创建根节点
            XmlElement root = doc.CreateElement("updateFiles");
            //头声明
            XmlDeclaration xmldecl = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(xmldecl);
            DirectoryInfo dicInfo = new DirectoryInfo(currentDirectory);
            
            //调用递归方法组装xml文件
            PopuAllDirectory(doc, root, dicInfo);
            //追加节点
            doc.AppendChild(root);
            //保存文档
            doc.Save(serverXmlName);
        }

        //递归组装xml文件方法
        private void PopuAllDirectory(XmlDocument doc, XmlElement root, DirectoryInfo dicInfo)
        {
            foreach (FileInfo f in dicInfo.GetFiles())
            {
                //排除当前目录中生成xml文件的工具文件
                if (f.Name != "CreateXmlTools.exe" && f.Name != "AutoupdateService.xml")
                {
                    string path = dicInfo.FullName.Replace(currentDirectory, "").Replace("\\", "/");
                    string folderPath=string.Empty;
                    if (path != string.Empty)
                    {
                        folderPath = path.TrimStart('/') + "/";
                    }
                    XmlElement child = doc.CreateElement("file");
                    child.SetAttribute("path", folderPath + f.Name);
                    child.SetAttribute("url", url + path + "/" + f.Name);
                    child.SetAttribute("lastver", FileVersionInfo.GetVersionInfo(f.FullName).FileVersion);
                    child.SetAttribute("size", f.Length.ToString());
                    child.SetAttribute("needRestart", "false");
                    child.SetAttribute("version", Guid.NewGuid().ToString());
                    root.AppendChild(child);
                }
            }

            foreach (DirectoryInfo di in dicInfo.GetDirectories())
                PopuAllDirectory(doc, root, di);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            url = "http://" + txtWebUrl.Text.Trim();
            CreateXml();
            ReadXml();
        }

        private void ReadXml()
        {
            string path="AutoupdateService.xml";
            rtbXml.ReadOnly = true;
            if (File.Exists(path))
            {
                rtbXml.Text = File.ReadAllText(path);
            }
        }

        private void txtWebUrl_Enter(object sender, EventArgs e)
        {
            txtWebUrl.ForeColor = Color.Black;
            if (txtWebUrl.Text.Trim() == "localhost:8017")
            {
                txtWebUrl.Text = string.Empty;
            }
        }
        
    }
}

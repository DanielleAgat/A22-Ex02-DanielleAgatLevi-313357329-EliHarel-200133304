﻿using System;

namespace BasicFacebookFeatures
{
     using BasicFacebookFeatures.Properties;
     using FacebookWrapper.ObjectModel;
     using System.Drawing;
     using System.IO;
     using System.Windows.Forms;
     using System.Xml.Linq;
     using System.Xml.Serialization;

     public class AppSettings
     {
          private static string s_FilePath;
          private const string k_DefaultFilePath = @"C:\Temp\appSettings.xml";
          private const bool k_RememberUser = true;
          private Point m_LastWindowLocation;
          private Size m_LastWindowSize;
          private bool m_IsRememberUser;
          private string m_LastAccessToken;

          private AppSettings()
          {
               m_LastWindowLocation = new Point(150, 150);
               m_LastWindowSize = new Size(753, 559);
               m_IsRememberUser = !k_RememberUser;
               m_LastAccessToken = null;
          }

          static AppSettings()
          {
               s_FilePath = k_DefaultFilePath;
          }

          public Point LastWindowLocation
          {
               get
               {
                    return m_LastWindowLocation;
               }
               set
               {
                    m_LastWindowLocation = value;
               }
          }

          public Size LastWindowSize
          {
               get
               {
                    return m_LastWindowSize;
               }
               set
               {
                    m_LastWindowSize = value;
               }
          }

          public bool IsRememberUser
          {
               get
               {
                    return m_IsRememberUser;
               }
               set
               {
                    m_IsRememberUser = value;
               }
          }

          public string LastAccessToken
          {
               get
               {
                    return m_LastAccessToken;
               }
               set
               {
                    m_LastAccessToken = value;
               }
          }

          public void SaveToFile()
          {
               Stream stream;

               if (File.Exists(s_FilePath))
               {
                    stream = new FileStream(s_FilePath, FileMode.Truncate);
               }
               else
               {
                    stream = new FileStream(s_FilePath, FileMode.CreateNew);
               }

               using (stream)
               {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());

                    serializer.Serialize(stream, this);
               }
          }

          public static AppSettings LoadFromFile()
          {
               AppSettings obj = new AppSettings();

               if (File.Exists(s_FilePath) && new FileInfo(s_FilePath).Length != 0)
               {
                    try
                    {
                         using (Stream stream = new FileStream(s_FilePath, FileMode.Open))
                         {
                              XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));

                              obj = serializer.Deserialize(stream) as AppSettings;
                         }
                    }
                    catch (Exception exception)
                    {
                    }
               }

               return obj;
          }

          public void SaveDefault()
          {
               if (File.Exists(s_FilePath))
               {
                    File.Delete(s_FilePath);
               }
          }
     }
}

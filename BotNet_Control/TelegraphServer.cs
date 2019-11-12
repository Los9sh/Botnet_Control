﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotNet_Control
{
    class TelegraphServer
    {
        public String access_token { get; set; }

        private string api { get; } = "https://api.graph.org";

        public TelegraphServer()
        {
            access_token = string.Empty;
        }

        public TelegraphServer(string access_token)
        {
            this.access_token = access_token;
        }

        private string[] JsonClear(string JsonCode)
        {
            string clean = JsonCode.Replace("{", "").Replace("}", "").Replace("[", "").Replace("]", "").Replace("\"", "");
            return clean.Split(',');
        }

        public string CreateAccount(string Name)
        {
            // https://api.telegra.ph/createAccount?short_name=Sandbox&author_name=Anonymous

            if (string.IsNullOrEmpty(Name))
            {
                return null;
            }

            string result = web.SendPOST($"{api}/createAccount", $"short_name={Name}");
            
            string[] result_array = JsonClear(result);

            if (result_array[0] == "ok:true")
            {
                for(int i = 0; i < result_array.Length; i++)
                {
                    if (result_array[i].Contains("access_token"))
                    {
                        string[] tmp_array = result_array[i].Split(':');
                        access_token = tmp_array[tmp_array.Length - 1];

                        break;
                    }
                }
            }

            return access_token;
        }

        public List<string> GetPageList()
        {
            // https://api.telegra.ph/getPageList?access_token=b968da509bb76866c35425099bc0989a5ec3b32997d55286c657e6994bbb

            string result = web.SendPOST($"{api}/getPageList", $"access_token={access_token}");

            string[] result_array = JsonClear(result);

            List<string> pages = new List<string>();

            if (result_array[0] == "ok:true")
            {
                for(int i = 0; i < result_array.Length; i++)
                {
                    if (result_array[i].Contains("path"))
                    {
                        string[] tmp_array = result_array[i].Split(':');
                        pages.Add(tmp_array[tmp_array.Length - 1]);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ошибка. GetPageList.");
            }

            return pages;
        }

        public string CreatePage(string Title)
        {
            // https://api.telegra.ph/createPage?access_token=b968da509bb76866c35425099bc0989a5ec3b32997d55286c657e6994bbb&title=Sample+Page&author_name=Anonymous&content=[{%22tag%22:%22p%22,%22children%22:[%22Hello,+world!%22]}]&return_content=true

            string result = web.SendPOST($"{api}/createPage", $"access_token={access_token}&title={Title}&content=[{{\"tag\":\"p\",\"children\":[\"0{{split}}0\"]}}]&return_content=false");

            string[] result_array = JsonClear(result);

            string created_page = string.Empty;

            if (result_array[0] == "ok:true")
            {
                for (int i = 0; i < result_array.Length; i++)
                {
                    if (result_array[i].Contains("path"))
                    {
                        string[] tmp_array = result_array[i].Split(':');
                        create_page = tmp_array[tmp_array.Length - 1];

                      break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Ошибка. CreatePage. Страница не найдена!");
            }
            return created_page;
        }

        public bool EditPage(string PagePath, string Title, string Content)
        {
            // https://api.telegra.ph/editPage/Sample-Page-12-15?access_token=b968da509bb76866c35425099bc0989a5ec3b32997d55286c657e6994bbb&title=Sample+Page&author_name=Anonymous&content=[{%22tag%22:%22p%22,%22children%22:[%22Hello,+world!%22]}]&return_content=true

            string result = web.SendPOST($"{api}/editPage/{PagePath}", $"access_token={access_token}&title={Title}&content=[{{\"tag\":\"p\",\"children\":[\"{Content}\"]}}]&return_content=false");

            string[] result_array = JsonClear(result);

            if (result_array[0] != "ok:true")
            {
                MessageBox.Show("Ошибка. EditPage. Страница не была отредактирована!");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

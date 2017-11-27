using beloArte.Domain;
using beloArte.Domain.Entidades_Temp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web.Script.Serialization;

namespace beloArte.Infra.ProdutoINFRA
{
    public class ProdutoINFRA
    {
        private BA_PRODUTO produto;
        private Product product;

        private BA_PRODUTO getJSONProduto()
        {

            try
            {
                produto = new BA_PRODUTO();

                var request = (HttpWebRequest)WebRequest.Create("http://beloart.azurewebsites.net/api/product");
                request.Method = "GET";
                request.ContentType = "application/x-www-form-urlencoded";                
                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                produto = JsonConvert.DeserializeObject<BA_PRODUTO>(responseString);

                return produto;
            }
            catch (Exception)
            {
                return produto;
            }
        }

        public Product CarregarTodosProdutos()
        {
            try
            {
                product = new Product();

                var request = (HttpWebRequest)WebRequest.Create("http://beloart.azurewebsites.net/api/product");
                request.Method = "GET";
                request.ContentType = "application/x-www-form-urlencoded";
                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                product = JsonConvert.DeserializeObject<Product>(responseString);

                return product;
            }
            catch (Exception e)
            {
                string erro = e.Message;
                throw;
            }
        }

    }
}

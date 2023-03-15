using Librarypzlab002.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Librarypzlab002
{
    public class DocumentService
    {
        public List<Document> documents = new List<Document>();

        public DocumentService() { }

        public void AddDocument(Document temp)
        {
            if (documents.Exists(x => x.ISBN == temp.ISBN))
                throw new WrongDocumentException("Dokument o takim ISBN już istnieje!");
            
            if (temp is Volume && ((Volume)temp).NumbersOfVolume > ((Volume)temp).NumbersOfAllVolume)
                throw new WrongDocumentException("Numer tomu jest wiekszy niz liczba wszystkich");

            if (temp is Book && temp.PublicationYear < 1450)
                throw new WrongDocumentException("Rok wydania ksiazki jest nizszy niz data wnalezienia druku");

            documents.Add(temp);
        }

        public Document GetDocumentByISBN(int temp)
        {
            var document = documents.FirstOrDefault(x => x.ISBN == temp);
            return document;
        }

        public List<Document> GetDocumentsWithTitle(string temp) 
        { 
            var tempdoc = documents.FindAll(x => x.Title.Contains(temp));

            return tempdoc;
        }

        public List<Magazine> GetMagazineByFrequency(FrequencyEnum temp)
        {
            List<Magazine> tempdoc = documents.OfType<Magazine>().Where(x => x.Frequency == temp).Cast<Magazine>().ToList();

            return tempdoc;
        }
    }
}

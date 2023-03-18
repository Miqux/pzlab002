using Librarypzlab002;
using Librarypzlab002.Models;

DocumentService documentService = new DocumentService();

documentService.AddDocument(new Magazine(1, "Przygody", 2012, 3, 1, FrequencyEnum.Dziennik));
documentService.AddDocument(new Magazine(2, "Kot Tomka", 2012, 3, 1, FrequencyEnum.Dziennik));
documentService.AddDocument(new Magazine(3, "Przygody Marka", 2012, 3, 1, FrequencyEnum.Dziennik));
documentService.AddDocument(new Magazine(4, "osiem", 2012, 3, 1, FrequencyEnum.Dziennik));
documentService.AddDocument(new Magazine(5, "Przygody", 2012, 3, 1, FrequencyEnum.Miesięcznik));
documentService.AddDocument(new Volume(6, "Volumetemp2", 2010, 2, "Roman", 1, 4));
documentService.AddDocument(new Volume(7, "Volumetemp3", 2012, 22, "Mariusz", 2, 3));
documentService.AddDocument(new Volume(8, "Volumetemp1", 2011, 41, "Marek", 3, 3));
documentService.AddDocument(new Volume(9, "Volumetemp4", 2022, 12, "Darek", 1, 5));
documentService.AddDocument(new Book(10, "Book1", 2012, 12, "Ola"));
documentService.AddDocument(new Book(11, "Book2", 2017, 122, "Asia"));
documentService.AddDocument(new Book(12, "Book3", 2022, 232, "Zuzia"));
documentService.AddDocument(new Book(13, "Book4", 2022, 89, "Darek"));
documentService.AddDocument(new Book(14, "Book5", 2023, 69, "Marek"));
documentService.AddDocument(new Book(15, "Book6", 2021, 132, "Bartek"));
documentService.AddDocument(new Book(16, "Book7", 2018, 112, "Olek"));

documentService.documents.ForEach(x => Console.WriteLine(x));
Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
Console.WriteLine(documentService.GetDocumentByISBN(1));
Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
Console.WriteLine(documentService.GetDocumentByISBN(6));
Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

foreach (var item in documentService.GetDocumentsWithTitle("Book"))
{
    Console.WriteLine(item);
}
Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
foreach (var item in documentService.GetDocumentsWithTitle("2"))
{
    Console.WriteLine(item);
}
Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
foreach (var item in documentService.GetMagazineByFrequency(FrequencyEnum.Dziennik))
{
    Console.WriteLine(item);
}
Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
documentService.documents.ForEach(x => Console.WriteLine(x.Print()));
Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
try
{
    documentService.AddDocument(new Book(10, "Book99", 2000, 14, "Basia"));
}
catch (WrongDocumentException e)
{
    Console.WriteLine($"Wrong document: {e.Message}");
}
try
{
    documentService.AddDocument(new Volume(46, "Volumetemp2", 2010, 2, "Roman", 5, 4));
}
catch (WrongDocumentException e)
{
    Console.WriteLine($"Wrong document: {e.Message}");
}
try
{
    documentService.AddDocument(new Book(2222, "Book32", 1000, 1, "Olek"));
}
catch (WrongDocumentException e)
{
    Console.WriteLine($"Wrong document: {e.Message}");
}
// See https://aka.ms/new-console-template for more information
using Example;
using Telerik.Windows.Zip;

var filePath = Path.GetTempFileName();
using (var stream = File.Open(filePath, FileMode.Create))
{
    var array = new RegulationItem[1] { new RegulationItem() };
    array[0].LoadCards.Add(new LoadCard());
    array[0].LoadCards[0].Dictionary.Add("Key", 0x00);

    using (var archive = new ZipArchive(stream, ZipArchiveMode.Create, false, null))
    {
        foreach (var item in array)
        {
            using (var entry = archive.CreateEntry($"{item.Name}.reg-ext"))
            {
                XmlInOut<RegulationItem>.SaveToStream(entry.Open(), item);
            }
        }
    }
}


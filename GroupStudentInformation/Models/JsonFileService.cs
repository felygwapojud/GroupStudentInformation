using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using GroupStudentInformation.Models;
using System.Xml;

public class JsonFileService
{
    private readonly string _filePath = "accounts.json";

    public List<UserAccount> LoadAccounts()
    {
        if (!File.Exists(_filePath)) return new List<UserAccount>();
        var jsonData = File.ReadAllText(_filePath);
        return JsonConvert.DeserializeObject<List<UserAccount>>(jsonData) ?? new List<UserAccount>();
    }

    public void SaveAccounts(List<UserAccount> accounts)
    {
        var jsonData = JsonConvert.SerializeObject(accounts, Newtonsoft.Json.Formatting.Indented);
        File.WriteAllText(_filePath, jsonData);
    }
}
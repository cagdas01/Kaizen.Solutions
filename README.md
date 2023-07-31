
# Kaizen Solutions Case Study
## Question 1 :Generate Codes

 - #### Algorithm :

 
This C# code includes a method that aims to generate a specified number of unique random codes. The generated codes are 8 characters long and consist of randomly selected characters within a certain character set. The codes are checked so that they do not conflict with previously generated ones, and a list of unique codes is returned as a result.

- #### Requirements :
To run this code, you need:

.Net 6 and higher versions environment that supports C# (e.g., .NET Core, .NET Framework)

#### Produce Codes

```http
  HashSet<string> GenerateCodes(int count); 
```

| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `count` | `int` | **Required**. the number of codes|

#### var codes = codeGenerator.GenerateCodes(1000);

codes is generated unique 8 digit codes


## Question 2 :Json Parse

 - #### Algorithm :

 
It is an algorithm that organizes json-format receipts from an ocr-based system according to their vertical and horizontal positions. As a result, a text-based output sequence is created, comments of receipts in the same vertical position on each line are combined, and the line number is added.

- #### Requirements :
To run this code, you need:

.Net 6 and higher versions environment that supports C# (e.g., .NET Core, .NET Framework)


#### GetParsedDataList

```http
  string GetParsedDataList(string jsondata);
```

| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `jsondata` | `string` | **Required**. jsondata parameter retrieved from SaaS service for a specific voucher|

#### var receiptsFullText = JsonParseService.GetParsedDataList(Constants.RECEIPTJSONDATA);


receiptsFullText is parsed total String Data

## How to Run


```http
  You can set the project of the algorithm you want to run as "set as startup project" and run the project with the dotnet run command.
```

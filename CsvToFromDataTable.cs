
using System.Data;

string csv =$"id,name{Environment.NewLine}1,hello{Environment.NewLine}2,Main";

var bytsarr = Encoding.ASCII.GetBytes(csv);

var f = System.IO.File.Create("F:\\test.txt");
f.Write(bytsarr,0,bytsarr.Length);
f.Close();

bytsarr.Dump();

//csv.Dump();

DataTable dt = new DataTable();
var rows = csv.Split(Environment.NewLine);
rows.Dump();

if(rows?.Count()> 0)
{
  var arrcolumns =   rows[0].Split(',');
  foreach(var item in arrcolumns)
  {
    dt.Columns.Add(item);
  }
  
for(int i=1;i<rows.Count();i++)
{
var rowsarr = rows[i].Split(',');
 dt.Rows.Add(rowsarr); 
}

}

//dt.Dump();

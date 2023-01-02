# Split a collection into several collections

This is a LINQ extension to split a collection into multiple collections using a given condition as a separator.<br />
Think of it as `String.Split()` for collections.

Example: Using an array of separators
--------
```
string[] things = { "pie", "apple", "cake", "mud-pie", "nuts", "plum", "mud-spread", "milk", "butter" };
var edibleThings = things.Split("mud-pie", "mud-spread");
```
edibleThings will contain these string collections: <br />
   {"pie", "apple", "cake"}<br />
   {"nuts", "plum"}<br />
   {"milk", "butter"}<br />


Example: Using a function to define the separator
--------
```
string[] things = { "pie", "apple", "cake", "mud-pie", "nuts", "plum", "mud-spread", "milk", "butter" };
var edibleThings = things.Split(t => t.StartsWith("mud"));
```
edibleThings will contain these string collections: <br />
   {"pie", "apple", "cake"}<br />
   {"nuts", "plum"}<br />
   {"milk", "butter"}
   
# Use Cases
This can be useful when useful information is separated by known delimiters. For example, a text file containing records where each record is separated by certain characters, or whitespace. <br />
Simply read the text file, and perform a `Split()`, passing in the delimiter(s), or the criteria for the delimiter(s).

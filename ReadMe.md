### Extensions
> Simple and useful extension methods that provide a more fluent way to express code intent and simplify common usage.

#### Contents
* [Contributing](#contributing)
* [Example One](#example_one)
* [Example Two](#example_two)
* [Available String Extensions](#string_extensions)
* [Available Class Extensions](#class_extensions)
* [Available Boolean Extensions](#boolean_extensions)
* [Available Integer Extensions](#integer_extensions)
* [Available DateTime Extensions](#datetime_extensions)

#### Contributing
Anyone may contribute to this project by creating a branch and submitting a pull request. All contributions must
be code that is not specific to any single project. Extension should be simple common helpers, and are explicitly named as to their intent.
All extension methods must be well documented with XML and must contain Unit Tests.

Also, all new extensions must be documented in the ReadMe file.

___

The examples below show the difference between "normal" code and the extension methods. In both cases
the extension method is easier to understand and requires less code.

###### Example One
```csharp
var str = "1234";

// Normal code to parse a string to an int.
int value = int.TryParse(str, out var value) ? value : 0;

// With extension method
int value = str.ToIntOrDefault();
```

###### Example Two
```csharp
Nullable<DateTime> date = new DateTime(2000, 12, 31);

// Normal code to check if date is set to today's date
bool isToday = date.HasValue && date.Value.Date == DateTime.Today.Date;

// With extension method
bool isToday = date.IsToday();
```

___


### Available Extensions

##### String Extensions
| Method									| Description	|
|-------------								| -----			|
| [string].IsNullOrEmpty()					| Simplified way to call `string.IsNullOrWhiteSpace([string])` |
| [string].IsNotNullOrEmpty()				| Simplified was to call `!string.IsNullOrWhiteSpace([string]` |
| [string].ToIntOrDefault()					| Converts a string value to an integer. If value cannot be converted, zero (0) is returned. |
| [string].ToIntOrError()					| Converts a string value to an integer. If value cannot be converted, an `ArgumentException` is returned. |
| [string].ToBoolOrDefault()				| Converts a string value to a boolean. If value cannot be converted, false is returned.|
| [string].ToBoolOrError()					| Converts a string value to a boolean. If value cannot be converted, an `ArgumentException` is returned. |

___

##### Class Extensions
| Method									| Description	|
|-------------								| -----			|
| [class].IsNull()							| Returns boolean - true if object is null, else false	|
| [class].IsNotNull()						| Returns boolean - false if object is null, else true	|
| [class].SerializeToXml()					| Returns string as XML representation of the object.	|
| [class].Clone()							| Uses `JsonConverter` to return a deep copy of the object. |
| [class].ToJObject()						| Converts the object to a `JObject` (JSON object).		|
| [class].ToJson()							| Converts the object to a JSON string.		|

___

##### Boolean Extensions
| Method									| Description	|
|-------------								| -----			|
| [bool].ToDefaultString()					| Returns the string representation of the boolean value ("True", or "False"). If boolean in null will return "False". |
| [bool].IsTrue()							| For Nullable Booleans only. Will return true if true, else false. |
| [bool].IsFalse()							| For Nullable Booleans only. Will return true if false, else true. |
| [bool].ToBitString()						| Returns a bit (1 or 0) as string value. "1" for true, "0" for false. If null will return "0" |
| [bool].ToInteger()						| Returns a bit (1 or 0) as an integer value. 1 for true, 0 for false. If null will return 0 |

___

##### Integer Extensions
| Method									| Description	|
|-------------								| -----			|
| [int].ToDefaultString()					| For Nullable Integers only. Will return the integer value as a string. If null will return "0" |
| [int].IsGreaterThan(int)					| Returns true if integer is greater than the supplied value, else false. null values will return false. |
| [int].IsLessThan(int)						| Returns true if integer is less than the supplied value, else false. null values will return false. |
| [int].IsGreaterThanOrEqual(int)			| Returns true if integer is greater than or equal to the supplied value, else false, null values will return false. |
| [int].IsLessThanOrEqual(int)				| Returns true if integer is less than or equal to the supplied value, else false. null values will return false. |

___

##### DateTime Extensions
| Method									| Description	|
|-------------								| -----			|
| [DateTime].IsAfter(date, excludeTime)		| Returns true if the DateTime is after the passed in date. Optional excludeTime will exclude the TimeSpan from the Dates. |
| [DateTime].IsBefore(date, excludeTime)	| Returns true if the DateTime is before the passed in date. Optional excludeTime will exclude the TimeSpan from the Dates. |
| [DateTime].IsToday()						| Returns true if the DateTime is todays date. Will exclude the TimeSpan from the check. |

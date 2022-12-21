using Schema.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Schema.Types
{
    public class String
    {
        [JsonPropertyName("$id")]
        public string Id { get; set; }
        [JsonPropertyName("$ref")]
        public string Ref { get; set; }
        [JsonPropertyName("type")]
        public string Type = "string";
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("pattern")]
        public Regex Pattern { get; set; }
        [JsonPropertyName("maxLength")]
        public int MaxLength { get; set; }
        [JsonPropertyName("minLength")]
        public int MinLength { get; set; }
        [JsonPropertyName("enum")]
        public List<string> Enum { get; set; } = new List<string>();
        [JsonPropertyName("default")]
        public string Default { get; set; }
        [JsonPropertyName("examples")]
        public List<string> Examples { get; set; } = new List<string>();

        public String()
        {
        }
        public String(int Max, int Min)
        {
            MaxLength = Max;
            MinLength = Min;
        }
        public String(Regex pattern)
        {
            Pattern = pattern;
        }
        public void AddExample(string Value)
        {
            Examples.Add(Value);
        }
        public void AddEnum(string Value)
        {
            Enum.Add(Value);
        }
        public override string ToString()
        {
            return JsonSerializer.Serialize<String>(this);
        }
    }
    public class Number
    {
        [JsonPropertyName("$id")]
        public string Id { get; set; }
        [JsonPropertyName("$ref")]
        public string Ref { get; set; }
        [JsonPropertyName("type")]
        public string Type = "number";
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("minimum")]
        public decimal Minimum { get; set; }
        [JsonPropertyName("maximum")]
        public decimal Maximum { get; set; }
        [JsonPropertyName("exclusiveMinimum")]
        public decimal ExclusiveMinimum { get; set; }
        [JsonPropertyName("exclusiveMaximum")]
        public decimal ExclusiveMaximum { get; set; }
        [JsonPropertyName("multipleOf")]
        public decimal MultipleOf { get; set; }
        [JsonPropertyName("default")]
        public decimal Default { get; set; }
        [JsonPropertyName("examples")]
        public List<decimal> Examples { get; set; } = new List<decimal>();
        public Number()
        {
        }
        public Number(decimal Max, decimal Min)
        {
            Maximum = Max;
            Minimum = Min;
        }
        public void AddExample(decimal Value)
        {
            Examples.Add(Value);
        }
        public override string ToString()
        {
            return JsonSerializer.Serialize<Number>(this);
        }
    }
    public class Integer
    {
        [JsonPropertyName("$id")]
        public string Id { get; set; }
        [JsonPropertyName("$ref")]
        public string Ref { get; set; }
        [JsonPropertyName("type")]
        public string Type = "integer";
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("minimum")]
        public int Minimum { get; set; }
        [JsonPropertyName("maximum")]
        public int Maximum { get; set; }
        [JsonPropertyName("exclusiveMinimum")]
        public int ExclusiveMinimum { get; set; }
        [JsonPropertyName("exclusiveMaximum")]
        public int ExclusiveMaximum { get; set; }
        [JsonPropertyName("multipleOf")]
        public int MultipleOf { get; set; }
        [JsonPropertyName("default")]
        public int Default { get; set; }
        [JsonPropertyName("examples")]
        public List<int> Examples { get; set; } = new List<int>();
        public Integer()
        {
        }
        public Integer(int Max, int Min)
        {
            Maximum = Max;
            Minimum = Min;
        }
        public void AddExample(int Value)
        {
            Examples.Add(Value);
        }
        public override string ToString()
        {
            return JsonSerializer.Serialize<Integer>(this);
        }
    }
    public class Boolean
    {
        [JsonPropertyName("$id")]
        public string Id { get; set; }
        [JsonPropertyName("$ref")]
        public string Ref { get; set; }
        [JsonPropertyName("type")]
        public string Type = "boolean";
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("default")]
        public bool Default { get; set; }
        [JsonPropertyName("enum")]
        public List<bool> Enum { get; set; } = new List<bool>();
        public override string ToString()
        {
            return JsonSerializer.Serialize<Boolean>(this);
        }
    }
    public class Object
    {
        [JsonPropertyName("$id")]
        public string Id { get; set; }
        [JsonPropertyName("$ref")]
        public string Ref { get; set; }
        [JsonPropertyName("type")]
        public string Type = "object";
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("properties")]
        public List<dynamic> Properties { get; set; } = new List<dynamic>();
        [JsonPropertyName("required")]
        public List<string> Required { get; set; } = new List<string>();
        [JsonPropertyName("additionalProperties")]
        public bool AdditionalProperties { get; set; } = false;
        [JsonPropertyName("default")]
        public dynamic Default { get; set; }
        [JsonPropertyName("enum")]
        public List<dynamic> Enum { get; set; } = new List<dynamic>();
        public Object()
        {
        }
        public void AddProperty (dynamic value)
        {
            Properties.Add(value);
        }
        public void AddEnum (dynamic value)
        {
            Enum.Add(value);
        }
        public override string ToString()
        {
            return JsonSerializer.Serialize<Object>(this);
        }
    }
    public class Array
    {
        [JsonPropertyName("$id")]
        public string Id { get; set; }
        [JsonPropertyName("$ref")]
        public string Ref { get; set; }
        [JsonPropertyName("type")]
        public string Type = "array";
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("items")]
        public List<dynamic> Items { get; set; } = new List<dynamic>();
        [JsonPropertyName("additionalItems")]
        public bool AdditionalItems { get; set; } = false;
        [JsonPropertyName("default")]
        public dynamic Default { get; set; }
        public Array()
        {
        }
        public void AddItems(dynamic Value)
        {
            Items.Add(Value);
        }
        public override string ToString()
        {
            return JsonSerializer.Serialize<Array>(this);
        }
    }
    public class Definition
    {
        [JsonPropertyName("type")]
        public string Type = "object";
        [JsonPropertyName("properties")]
        public List<dynamic> Properties { get; set; } = new List<dynamic>();
        [JsonPropertyName("required")]
        public List<string> Required { get; set; } = new List<string>();
    }
    public class Document
    {
        [JsonPropertyName("$id")]
        public string Id { get; set; }
        [JsonPropertyName("$ref")]
        public string Ref { get; set; }
        [JsonPropertyName("$schema")]
        public string Schema { get; set; }
        [JsonPropertyName("definitions")]
        public List<Definition> Definitions { get; set; }
        [JsonPropertyName("type")]
        public string Type = "object";
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("properties")]
        public List<dynamic> Properties { get; set; } = new List<dynamic>();
        [JsonPropertyName("required")]
        public List<string> Required { get; set; } = new List<string>();
        [JsonPropertyName("additionalProperties")]
        public bool AdditionalProperties { get; set; } = false;
        [JsonPropertyName("default")]
        public dynamic Default { get; set; }
        [JsonPropertyName("enum")]
        public List<dynamic> Enum { get; set; } = new List<dynamic>();
        public Document()
        {
        }
        public void AddProperty(dynamic value)
        {
            Properties.Add(value);
        }
        public void AddEnum(dynamic value)
        {
            Enum.Add(value);
        }
        public void AddDefinition(Definition value)
        {
            Definitions.Add(value);
        }
        public override string ToString()
        {
            return JsonSerializer.Serialize<Document>(this);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Text.Json;
using System.Net;
using System.Text.RegularExpressions;
using Microsoft.PowerShell.Commands;

namespace Schema.Cmdlets
{
    [Cmdlet(VerbsCommon.New, "SchemaDocument", HelpUri = "")]
    [OutputType(typeof(Schema.Types.Document))]
    [CmdletBinding(PositionalBinding = true)]
    public class NewDocumentCmdlet : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string Id { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string Ref { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string Title { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 4)]
        [ValidateSet("http://json-schema.org/draft-04/schema#", "http://json-schema.org/draft-06/schema#", "http://json-schema.org/draft-07/schema#")]
        public string Schema { get; set; } = string.Empty;
        [Parameter(Mandatory = false, Position = 4)]
        public List<Types.Definition> Definitions { get; set; } = new List<Types.Definition>();
        [Parameter(Mandatory = false, Position = 5)]
        public string Description { get; set; } = string.Empty;
        [Parameter(Mandatory = false, Position = 6)]
        public List<dynamic> Properties { get; set; } = new List<dynamic>();
        [Parameter(Mandatory = false, Position = 7)]
        public List<string> Required { get; set; } = new List<string>();
        [Parameter(Mandatory = false, Position = 8)]
        public bool AdditionalProperties { get; set; } = false;
        [Parameter(Mandatory = false, Position = 9)]
        public dynamic Default { get; set; }
        [Parameter(Mandatory = false, Position = 10)]
        public List<dynamic> Enum { get; set; } = new List<dynamic>();

        // This method gets called once for each cmdlet in the pipeline when the pipeline starts executing
        protected override void BeginProcessing()
        {
            WriteVerbose(Title);
        }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessRecord()
        {
            WriteObject(new Types.Document()
            {
                Id = Id,
                Ref = Ref,
                Schema = Schema,
                Definitions = Definitions,
                Title = Title,
                Description = Description,
                Properties = Properties,
                Required = Required,
                AdditionalProperties = AdditionalProperties,
                Default = Default,
                Enum = Enum
            });
        }

        // This method will be called once at the end of pipeline execution; if no input is received, this method is not called
        protected override void EndProcessing()
        {
            WriteVerbose("End!");
        }
    }
}
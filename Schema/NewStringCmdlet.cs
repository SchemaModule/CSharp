using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Text.Json;
using System.Net;
using System.Text.RegularExpressions;

namespace Schema.Cmdlets
{
    [Cmdlet(VerbsCommon.New, "SchemaString", HelpUri = "")]
    [OutputType(typeof(Schema.Types.String))]
    [CmdletBinding(PositionalBinding = true)]
    public class NewStringCmdlet : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string Id { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string Ref { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string Title { get; set; } = string.Empty;
        [Parameter(Mandatory = false, Position = 4)]
        public string Description { get; set; } = string.Empty;
        [Parameter(Mandatory = false, Position = 5)]
        public Regex Pattern { get; set; }
        [Parameter(Mandatory = false, Position = 6)]
        public int MaxLength { get; set; }
        [Parameter(Mandatory = false, Position = 7)]
        public int MinLength { get; set; }
        [Parameter(Mandatory = false, Position = 8)]
        public string Default { get; set; } = string.Empty;

        // This method gets called once for each cmdlet in the pipeline when the pipeline starts executing
        protected override void BeginProcessing()
        {
            WriteVerbose(Title);
        }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessRecord()
        {
            WriteObject(new Types.String()
            {
                Id = Id,
                Ref = Ref,
                Title = Title,
                Description = Description,
                Pattern = Pattern,
                MaxLength = MaxLength,
                MinLength = MinLength,
                Default = Default
            });
        }

        // This method will be called once at the end of pipeline execution; if no input is received, this method is not called
        protected override void EndProcessing()
        {
            WriteVerbose("End!");
        }
    }
}
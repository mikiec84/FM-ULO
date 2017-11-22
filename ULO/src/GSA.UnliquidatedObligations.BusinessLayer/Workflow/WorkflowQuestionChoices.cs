﻿using RevolutionaryStuff.Core;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace GSA.UnliquidatedObligations.BusinessLayer.Workflow
{
    [DataContract(Name="WorkflowChoices", Namespace= UloHelpers.WorkflowDescUrn)]
    public class WorkflowQuestionChoices
    {
        [DataMember(Name = "Label")]
        public string QuestionLabel { get; set; }

        [DataMember(Name = "Choices")]
        public List<QuestionChoice> Choices { get; set; }

        public IEnumerable<QuestionChoice> WhereMostApplicable(string documentType, string mostRecentNonReassignmentAnswer)
            => Choices == null ? 
                QuestionChoice.None : 
                Choices.Where(z => z.IsApplicable(documentType, mostRecentNonReassignmentAnswer)).
                    OrderBy(z => z.MostRecentNonReassignmentAnswer == null ? 0 : 1).
                    ToDictionaryOnConflictKeepLast(z=>z.Value, z=>z).Values;
    }
}
﻿namespace GSA.UnliquidatedObligations.BusinessLayer.Data
{
    public partial class ListableWorkflows_Result0
    {
        public string PdnWithInstance
            => UloHelpers.CreatePdnWithInstance(this.PegasysDocumentNumber, this.PegasysDocumentNumberInstance);
    }
}

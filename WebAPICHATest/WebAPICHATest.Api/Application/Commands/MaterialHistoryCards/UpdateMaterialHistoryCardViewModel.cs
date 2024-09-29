﻿namespace WebAPICHATest.Api.Application.Commands.MaterialHistoryCards
{
    public class UpdateMaterialHistoryCardViewModel
    {
        public string MaterialHistoryCardId { get; set; }
        public DateTime TimeStamp { get; set; }
        public decimal Before { get; set; }
        public decimal Input { get; set; }
        public decimal Output { get; set; }
        public decimal After { get; set; }
        public string MaterialInfor { get; set; }
        public string Note { get; set; }

        public UpdateMaterialHistoryCardViewModel(string materialHistoryCardId, DateTime timeStamp, decimal before, decimal input, decimal output, decimal after, string materialInfor, string note)
        {
            MaterialHistoryCardId = materialHistoryCardId;
            TimeStamp = timeStamp;
            Before = before;
            Input = input;
            Output = output;
            After = after;
            MaterialInfor = materialInfor;
            Note = note;
        }
    }
}

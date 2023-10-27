using System;
using System.Data;
using TestMedWinFormsApp.Entities;

namespace TestMedWinFormsApp.DB.Interfaces
{
    public interface IStepsRepository
    {
        DataTable GetFullTable();
        void DeleteStepById(int id);
        void AddStep(Step step);
        void UpdateStep(Step step);
        bool IsStepExist(Step step);

    }
}

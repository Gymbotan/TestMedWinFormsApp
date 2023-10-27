using System;
using System.Data;
using TestMedWinFormsApp.Entities;

namespace TestMedWinFormsApp.DB.Interfaces
{
    public interface IModesRepository
    {
        DataTable GetFullTable();
        void DeleteModeById(int id);
        void AddMode(Mode mode);
        bool IsModeExist(Mode mode);
        void UpdateMode(Mode mode);
    }
}

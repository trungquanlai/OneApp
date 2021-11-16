using OneApp.Data;
using PosRest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneApp.Services
{
    public class TableService : ITableService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TableService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Table> CreateTable(Table newTable)
        {
            await _unitOfWork.Tables.AddAsync(newTable);
            await _unitOfWork.CommitAsync();

            return newTable;
        }

        public async Task DeleteTable(Table table)
        {
            _unitOfWork.Tables.Remove(table);

            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Table>> GetAllTables()
        {
            return await _unitOfWork.Tables.GetAllAsync();
        }

        public async Task<Table> GetTableById(int id)
        {
            return await _unitOfWork.Tables.GetTableByIdAsync(id);
        }

        public async Task<Table> GetTableByName(string name)
        {
            return await _unitOfWork.Tables.GetTableByNameAsync(name);
        }

        public async Task UpdateTable(Table tableToBeUpdated, Table table)
        {
            tableToBeUpdated.Name = table.Name;

            await _unitOfWork.CommitAsync();
        }
    }
}

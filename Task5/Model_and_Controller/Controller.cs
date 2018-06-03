using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;
using ISorterProject;
using System.Windows.Forms;
using System.Linq;
using Task5.Tools;

namespace Task5.MVC
{
    public class Controller
    {
        private static object _syncDatabaseAccessing = new object();
        private Model _controllerModel;

        /// <summary>
        /// Constructor for controller
        /// </summary>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <param name="model">Model for controller to operate with</param>
        public Controller(Model model)
        {
            if (model == null)
            {
                throw new ArgumentNullException("model", "Controller cannot have model as null parameter");
            }

            _controllerModel = model;
        }

        public Model ControllerModel
        {
            get
            {
                return _controllerModel;
            }
        }

        public bool SameSelectedSorters(Sorter[] sorters)
        {
            if (sorters == null || _controllerModel.SelectedSorters == null)
            {
                return sorters == _controllerModel.SelectedSorters;
            }

            if (sorters.Length != _controllerModel.SelectedSorters.Length)
            {
                return false;
            }

            for (int i = 0; i < sorters.Length; i++)
            {
                if (sorters[i].GetType() != _controllerModel.SelectedSorters[i].GetType())
                {
                    return false;
                }
            }

            return true;
        }
        public void GetInputArrayFromDatabase(int arrayId)
        {
            lock (_syncDatabaseAccessing)
            {
                using (Database.SortersVisualizerDBEntities context = new Database.SortersVisualizerDBEntities())
                {
                    if (!context.Database.Exists())
                    {
                        throw new DatabaseDoesntExistException("The required database does not exist." +
                            "Check the availability of the appropriate database and try again.");
                    }

                    Database.InputArrays inputArray = (from array in context.InputArrays
                                                       where array.iInputArrayId == arrayId
                                                       select array).FirstOrDefault();

                    if (inputArray == null)
                    {
                        throw new KeyNotFoundException("The required array with ID = " + arrayId + " does not exist.");
                    }

                    int rows = inputArray.iNumberOfRows;
                    int columns = inputArray.iNumberOfColumns;

                    _controllerModel.ArrayForSorting = Utils.ConvertToTwoDimensionArray(inputArray.vcInputArrayContent, rows, columns);
                }
            }
        }
        public void AddSortedArrayToDatabase(Database.SortedArrays sortedArray)
        {
            lock (_syncDatabaseAccessing)
            {
                using (Database.SortersVisualizerDBEntities _context = new Database.SortersVisualizerDBEntities())
                {
                    if (!_context.Database.Exists())
                    {
                        throw new DatabaseDoesntExistException("Cannot insert sorted array into database. " +
                            "The required database does not exist.");
                    }

                    _context.SortedArrays.Add(sortedArray);
                    int rowsAffected = _context.SaveChanges();

                    if (rowsAffected != 1)
                    {
                        throw new System.Data.DBConcurrencyException("Error in inserting sorted array into database.");
                    }
                }
            }
        }
    }
}

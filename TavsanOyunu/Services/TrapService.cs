using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TavsanOyunu.Models;

namespace TavsanOyunu.Services
{
    public class TrapService
    {
        #region Definitions

        private List<ObjectCount> ObjectCounts { get; set; }
        private List<ObjectPosition> ObjectsPositions { get; set; }

        #endregion Definitions

        #region ctor

        public TrapService()
        {
            ObjectsPositions = new List<ObjectPosition>();
            ObjectCounts = new List<ObjectCount>();

            #region ObjectCount Seeds

            ObjectCounts.Add(new ObjectCount()
            {
                ObjectType = eObjectType.Wolf,
                Count = GetMaxObjectCount()
            });

            ObjectCounts.Add(new ObjectCount()
            {
                ObjectType = eObjectType.Barrier,
                Count = GetMaxObjectCount()
            });

            ObjectCounts.Add(new ObjectCount()
            {
                ObjectType = eObjectType.Fox,
                Count = GetMaxObjectCount()
            });

            ObjectCounts.Add(new ObjectCount()
            {
                ObjectType = eObjectType.Wire,
                Count = GetMaxObjectCount()
            });

            #endregion ObjectCount Seeds
        }

        #endregion ctor

        #region methods

        private void MapObjects(eObjectType objectType)
        {
            for (int i = 0; i < GetMappedObjectCount(objectType); i++)
            {
            }
        }

        private int GetMaxObjectCount()
        {
            return new Random().Next(1, 5);
        }

        private bool CheckPositionIsFree(int x, int y)
        {
            return ObjectsPositions.Any(a => a.LocationX == x && a.LocationY == y);
        }

        private int GetMappedObjectCount(eObjectType objectType)
        {
            int maxObjectCount = ObjectCounts.FirstOrDefault(f => f.ObjectType == objectType)?.Count ?? 4;
            int addedObjectCount = ObjectsPositions.Count(f => f.ObjectType == objectType);

            return maxObjectCount - addedObjectCount;
        }

        #endregion methods
    }
}
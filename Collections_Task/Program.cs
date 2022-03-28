using Collections_Task;

namespace Collections_Task
{
    class Program
    { 
        static void Main(string[] args)
        { 

            Entity[] entities = new Entity[]
            {
                new Entity(1, 0, "Root entity"),
                new Entity(2, 1, "Child of 1 entity"),
                new Entity(3, 1, "Child of 1 entity"),
                new Entity(4, 2, "Child of 2 entity"), 
                new Entity(5, 4, "Child of 4 entity")
            };

            Dictionary<int, List<Entity>> dict = ArrayToDictionary(entities);

            foreach (KeyValuePair<int, List<Entity>> keyvalue in dict)
            {
                Console.WriteLine($"Key = {keyvalue.Key}, Value = List {"{"} {String.Join(", ", keyvalue.Value)} {"}"}");
            }

        }

        static Dictionary<int, List<Entity>> ArrayToDictionary(Entity[] entities){
            Dictionary<int, List<Entity>> dict = new Dictionary<int, List<Entity>>();

            foreach(Entity entity in entities){
                if (!dict.ContainsKey(entity.ParentId))
                {
                    dict.Add(entity.ParentId, new List<Entity>());
                }
                dict[entity.ParentId].Add(entity);
            }

            return dict;
        }
    }
}

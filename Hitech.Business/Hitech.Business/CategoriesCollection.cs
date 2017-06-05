namespace Hitech.Business
{
    public class CategoriesCollection
    {
        private static GenericList<int, Category> CategoryList = new GenericList<int, Category>();

        public static void LoadCollection(GenericList<int, Category> list)
        {
            CategoryList = list;
        }

        public static GenericList<int, Category> GetCollection()
        {
            return CategoryList;
        }

        public static bool AddCategory(Category category)
        {
            return CategoryList.Add(category.CategoryId, category);
        }

        public static void RemoveCategory(Category category)
        {
            CategoryList.Remove(category.CategoryId);
        }

        public static Category GetCategory(int categoryId)
        {
            if (CategoryList.Contains(categoryId))
            {
                return CategoryList.GetByKey(categoryId);
            }
            else
            {
                return default(Category);
            }
        }

        public static int NextCategoryId()
        {
            int nextCategoryId = default(int);

            for (int i = 0; i < CategoryList.GetCount(); i++)
            {
                Category category = CategoryList[i];

                if (category.CategoryId > nextCategoryId)
                {
                    nextCategoryId = category.CategoryId;
                }
            }

            return (nextCategoryId + 1);
        }
    }
}

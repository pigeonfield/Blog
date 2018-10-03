using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class MockPostRepository : IPostRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();


        public IEnumerable<Post> Posts
        {
            get
            {
                return new List<Post>
                {
                    new Post {PostId = 1, Title = "Trip to Georgia", Date = DateTime.Parse("10/12/2017"),
                        Content ="Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, " +
                        "making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, " +
                        "consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. " +
                        "Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC." +
                        " This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit amet.., " +
                        "comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. " +
                        "Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by " +
                        "English versions from the 1914 translation by H.Rackham.",
                        ImageUrl = "~/Images/photo1.jpg",
                        ImageThumbnailUrl = "~/Images/photo1_m.jpg", IsPostofTheMonth = true,
                        //Category = _categoryRepository.Categories.ToList()[3] 
                    },

                    new Post {PostId = 2, Title = "Trip to Mexico", Date = DateTime.Parse("20/12/2017"),
                        Content ="Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, " +
                        "making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, " +
                        "consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. " +
                        "Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC." +
                        " This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit amet.., " +
                        "comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. " +
                        "Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by " +
                        "English versions from the 1914 translation by H.Rackham.",
                        ImageUrl = "~/Images/photo2.jpg",
                        ImageThumbnailUrl = "~/Images/photo2_m.jpg", IsPostofTheMonth = false,
                        //Category = _categoryRepository.Categories.ToList()[2] 
                    },

                    new Post {PostId = 3, Title = "Trip to Russia", Date = DateTime.Parse("29/01/20187"),
                        Content ="Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, " +
                        "making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, " +
                        "consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. " +
                        "Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC." +
                        " This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit amet.., " +
                        "comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. " +
                        "Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by " +
                        "English versions from the 1914 translation by H.Rackham.",
                        ImageUrl = "~/Images/photo3.jpg",
                        ImageThumbnailUrl = "~/Images/photo3_m.jpg", IsPostofTheMonth = true,
                        //Category = _categoryRepository.Categories.ToList()[3] 
                    },

                    new Post {PostId = 4, Title = "Trip to Norway", Date = DateTime.Parse("13/01/2018"),
                        Content ="Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, " +
                        "making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, " +
                        "consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. " +
                        "Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC." +
                        " This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit amet.., " +
                        "comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. " +
                        "Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by " +
                        "English versions from the 1914 translation by H.Rackham.",
                        ImageUrl = "~/Images/photo4.jpg",
                        ImageThumbnailUrl = "~/Images/photo4_m.jpg", IsPostofTheMonth = false,
                        //Category = _categoryRepository.Categories.ToList()[1] 
                    },

                    new Post {PostId = 5, Title = "Trip to Russia", Date = DateTime.Parse("29/03/2018"),
                        Content ="Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, " +
                        "making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, " +
                        "consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. " +
                        "Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC." +
                        " This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit amet.., " +
                        "comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. " +
                        "Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by " +
                        "English versions from the 1914 translation by H.Rackham.",
                        ImageUrl = "~/Images/photo5.jpg",
                        ImageThumbnailUrl = "~/Images/photo5_m.jpg", IsPostofTheMonth = true,
                        //Category = _categoryRepository.Categories.ToList()[3] 
                    },

                    new Post {PostId = 6, Title = "Trip to Norway", Date = DateTime.Parse("13/02/2018"),
                        Content ="Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, " +
                        "making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, " +
                        "consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. " +
                        "Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC." +
                        " This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit amet.., " +
                        "comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. " +
                        "Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by " +
                        "English versions from the 1914 translation by H.Rackham.",
                        ImageUrl = "~/Images/photo6.jpg",
                        ImageThumbnailUrl = "~/Images/photo6_m.jpg", IsPostofTheMonth = false,
                        //Category = _categoryRepository.Categories.ToList()[1] 
                    }


                };
            }

        }

        public IEnumerable<Post> PostsOfTheMonth { get; }

        public Post GetPostById(int postId)
        {
           throw new NotImplementedException();
        }

    
    }


    
}

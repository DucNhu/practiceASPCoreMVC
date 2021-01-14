using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace MoviesProjectMini.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Movies.Any())
            {
                context.Movies.AddRange(
                    new Movie
                    {

                        Name = "KHÓC CÙNG EM",

                        Title = "Mr. Siro x Gray x Wind (Official Music Video)",

                        Category = "Rap",

                        NameUser = "Mr.Siro Official",

                        Views = 2326236,

                        Time = "2 month ago",

                        link = "https://www.youtube.com/watch?v=X-GCJwz4PnY",
                    },
                    new Movie
                    {

                        Name = "Rap Bài Thơ Việt Bắc FUll Trọn Bài",

                        Title = "Mạnh Hakyno",
                        Category = "Hot",

                        NameUser = "Mr.Siro Official",

                        Views = 232636,

                        Time = "2 month ago",

                        link = "https://www.youtube.com/watch?v=dZQ1RAyqhs8",
                    },
                    new Movie
                    {

                        Name = "B.S.N.L 2 - B Ray ft. Young H",

                        Title = "( MASEW MIX )",
                        Category = "Hot",

                        NameUser = "xXx",

                        Views = 2326236,

                        Time = "2 month ago",

                        link = "https://www.youtube.com/watch?v=zENVcKkqZWg",
                    },
                    new Movie
                    {

                        Name = "MASEW | NÀNG THƠ",

                        Title = "ft. Ý Tiên | Official MV",
                        Category = "Hot",
                        NameUser = "Masew",

                        Views = 2326236,

                        Time = "2 month ago",

                        link = "https://youtu.be/EXpdUgk5P_w",
                    },
                    new Movie
                    {

                        Name = "KHÓC CÙNG EM",

                        Title = "Mr. Siro x Gray x Wind (Official Music Video)",
                        Category = "Hot",

                        NameUser = "Mr.Siro Official",

                        Views = 2326236,

                        Time = "2 month ago",

                        link = "https://www.youtube.com/watch?v=X-GCJwz4PnY",
                    },
                    new Movie
                    {

                        Name = "Buồn Thì Cứ Khóc Đi",

                        Title = "Lynk Lee | Official MV",
                        Category = "Rap",

                        NameUser = "Lynk Lee Official",

                        Views = 23226236,

                        Time = "9 month ago",

                        link = "https://www.youtube.com/watch?v=X-GCJwz4PnY",
                    },
                    new Movie
                    {

                        Name = "CHIỀU THU HỌA BÓNG NÀNG",

                        Title = "DATKAA x QT BEATZ | OFFICIAL MUSIC VIDEO",
                        Category = "Rap",
                        NameUser = "DatKaa Official",

                        Views = 23226236,

                        Time = "1 month ago",

                        link = "https://www.youtube.com/watch?v=PlVlWl8kKmg",
                    },
                    new Movie
                    {

                        Name = "SÓNG GIÓ",

                        Title = "OFFICIAL MUSIC VIDEO",
                        Category = "Hot",
                        NameUser = "J97",

                        Views = 123226236,

                        Time = "8 month ago",

                        link = "https://www.youtube.com/watch?v=j8U06veqxdU",
                    },
                    new Movie
                    {

                        Name = "Jack | Hoa Hải Đường",

                        Title = "GOfficial Music Video",
                        Category = "Hot",
                        NameUser = "J97",

                        Views = 623826236,

                        Time = "1 month ago",

                        link = "https://www.youtube.com/watch?v=Bhg-Gw953b0",
                    },
                    new Movie
                    {

                        Name = "Noo Phước Thịnh",

                        Title = "Gạt Đi Nước Mắt ft. Tonny Việt",
                        Category = "Rap",

                        NameUser = "Noo Phước Thịnh",

                        Views = 62326236,

                        Time = "4 year ago",

                        link = "https://www.youtube.com/watch?v=bD3B1I3Zgog",
                    },
                     new Movie
                     {

                         Name = "Đen - Lối Nhỏ",

                         Title = "ft. Phương Anh Đào (M/V)",
                         Category = "Hot",

                         NameUser = "Đen Vâu Official",

                         Views = 32326436,

                         Time = "1 year ago",

                         link = "https://www.youtube.com/watch?v=KKc_RMln5UY",
                     },
                    new Movie
                    {

                        Name = "Jack | Hoa Hải Đường",

                        Title = "Official Music Video",
                        Category = "Hot",

                        NameUser = "J97",

                        Views = 12346436,

                        Time = "1 month ago",

                        link = "https://www.youtube.com/watch?v=Bhg-Gw953b0",
                    });
                context.SaveChanges();
            }
        }
    }
}

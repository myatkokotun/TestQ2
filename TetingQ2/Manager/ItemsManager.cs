using TetingQ2.Models;

namespace TetingQ2.Manager
{
    public class ItemsManager
    {
        public List<Items> GetItems()
        {
            List<Items> items = new List<Items>() {
            new Items(){id=1, name="Computer", description="A computer is a machine that can be programmed to carry out sequences of arithmetic or logical operations automatically. Modern digital electronic computers can perform generic sets of operations known as programs. These programs enable computers to perform a wide range of tasks.", type="Electronic device", price=800},
            new Items(){id=2, name="Printer", description="In computing, a printer is a peripheral machine which makes a persistent representation of graphics or text, usually on paper. While most output is human-readable, bar code printers are an example of an expanded use for printers.", type="Printing device", price=760},
            new Items(){id=3, name="Table", description="A table is a piece of furniture with a flat table-style work surface used in a school, office, home or the like for academic, professional or domestic activities such as reading, writing, or using equipment such as a computer.[1][2] Desks often have one or more drawers, compartments, or pigeonholes to store items such as office supplies and papers.", type="Funiture", price=380},
            new Items(){id=4, name="Smartphone", description="A smartphone is a portable computer device that combines mobile telephone functions and computing functions into one unit.", type="Electronic device", price=900},
            new Items(){id=5, name="Chair", description="A chair is a type of seat, typically designed for one person and consisting of one or more legs, a flat or slightly angled seat and a back-rest. They may be made of wood, metal, or synthetic materials, and may be padded or upholstered in various colors and fabrics.", type="Funiture", price=500}
            };
            return items;
        }
    }
}

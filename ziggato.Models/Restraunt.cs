using System;
using ziggato.Models;
namespace ziggato.Models;

public class Restraunt
{

    public int RestrauntId { get; set; }
    public string RestrauntName { get; set; }
    public string RestrauntAddress { get; set; }
    public string RestrauntCity { get; set; }
    public DateTime OpeningTime { get; set; }
    public DateTime CloseingTime { get; set; }
    public string RestrauntType { get; set; }
    public bool isActive { get; set; }
    public List<MenuItem> Menu { get; set; }


}
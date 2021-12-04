using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Subtitle.DTO
{
    public class SubtitleDto
    {
        public string Segment { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Text { get; set; }
        public string Voice { get; set; }
        public string Token { get; set; }
    }
}

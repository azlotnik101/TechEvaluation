using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentCatalog
{
    public class CatalogData
    {
        public string ArtistId { get; set; }
        public string ActId { get; set; }
        public string ContentId { get; set; }
        public string ArtistName { get; set; }
        public string ArtistDisplayName { get; set; }
        public Track[] Tracks { get; set; }
    }

    public class Track
    {
        public string ReleaseTrackId { get; set; }
        public string ReleaseDate { get; set; }
        public int ReleaseYear { get; set; }
        public string ReleaseId { get; set; }
        public int ArtistRanking { get; set; }
        public string ArtistType { get; set; }
        public int DiskNumber { get; set; }
        public int Duration { get; set; }
        public int TrackNumber { get; set; }
        public string TrackTitle { get; set; }
    }
}



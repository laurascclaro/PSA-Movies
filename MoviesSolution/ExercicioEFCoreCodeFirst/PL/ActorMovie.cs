using System;
using System.Collections.Generic;
using System.Text;

namespace _ExercicioEFCoreCodeFirst.PL
{
    class ActorMovie
    {
        public int ActorMovieID { get; set; }
        public string Character { get; set; }

        public int ID { get; set; }//id do movie
        public Movie Movie { get; set; }

        public int ActorID{ get; set; }
        public Actor Actor { get; set; }
        


    }
}

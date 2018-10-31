
using System;
using OSIRISGenNHibernate.EN.OSIRIS;

namespace OSIRISGenNHibernate.CAD.OSIRIS
{
public partial interface IPeliculaCAD
{
PeliculaEN ReadOIDDefault (int id
                           );

void ModifyDefault (PeliculaEN pelicula);

System.Collections.Generic.IList<PeliculaEN> ReadAllDefault (int first, int size);



int New_ (PeliculaEN pelicula);

void Modify (PeliculaEN pelicula);


void Destroy (int id
              );
}
}


using System;
using OSIRISGenNHibernate.EN.OSIRIS;

namespace OSIRISGenNHibernate.CAD.OSIRIS
{
public partial interface ISerieCAD
{
SerieEN ReadOIDDefault (int id
                        );

void ModifyDefault (SerieEN serie);

System.Collections.Generic.IList<SerieEN> ReadAllDefault (int first, int size);



int New_ (SerieEN serie);

void Modify (SerieEN serie);


void Destroy (int id
              );
}
}

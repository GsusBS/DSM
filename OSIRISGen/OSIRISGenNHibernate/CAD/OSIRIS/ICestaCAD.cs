
using System;
using OSIRISGenNHibernate.EN.OSIRIS;

namespace OSIRISGenNHibernate.CAD.OSIRIS
{
public partial interface ICestaCAD
{
CestaEN ReadOIDDefault (int id
                        );

void ModifyDefault (CestaEN cesta);

System.Collections.Generic.IList<CestaEN> ReadAllDefault (int first, int size);



int New_ (CestaEN cesta);

void Modify (CestaEN cesta);


void Destroy (int id
              );
}
}

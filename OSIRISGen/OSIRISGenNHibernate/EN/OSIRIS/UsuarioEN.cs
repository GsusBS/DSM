
using System;
// Definición clase UsuarioEN
namespace OSIRISGenNHibernate.EN.OSIRIS
{
public partial class UsuarioEN
{
/**
 *	Atributo id
 */
private int id;






public virtual int Id {
        get { return id; } set { id = value;  }
}





public UsuarioEN()
{
}



public UsuarioEN(int id
                 )
{
        this.init (Id);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (Id);
}

private void init (int id
                   )
{
        this.Id = id;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioEN t = obj as UsuarioEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}

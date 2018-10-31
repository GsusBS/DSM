
using System;
// Definición clase SerieEN
namespace OSIRISGenNHibernate.EN.OSIRIS
{
public partial class SerieEN                                                                        : OSIRISGenNHibernate.EN.OSIRIS.ProductoEN


{
public SerieEN() : base ()
{
}



public SerieEN(int id,
               System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.CategoriaEN> categoria, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.CestaEN> cesta, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.ComentarioEN> comentario, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.CriticaEN> critica, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.BibliotecaEN> biblioteca, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.AdminEN> admin, string nombre
               )
{
        this.init (Id, categoria, cesta, comentario, critica, biblioteca, admin, nombre);
}


public SerieEN(SerieEN serie)
{
        this.init (Id, serie.Categoria, serie.Cesta, serie.Comentario, serie.Critica, serie.Biblioteca, serie.Admin, serie.Nombre);
}

private void init (int id
                   , System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.CategoriaEN> categoria, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.CestaEN> cesta, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.ComentarioEN> comentario, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.CriticaEN> critica, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.BibliotecaEN> biblioteca, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.AdminEN> admin, string nombre)
{
        this.Id = id;


        this.Categoria = categoria;

        this.Cesta = cesta;

        this.Comentario = comentario;

        this.Critica = critica;

        this.Biblioteca = biblioteca;

        this.Admin = admin;

        this.Nombre = nombre;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        SerieEN t = obj as SerieEN;
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

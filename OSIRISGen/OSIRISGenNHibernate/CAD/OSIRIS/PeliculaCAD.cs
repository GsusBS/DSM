
using System;
using System.Text;
using OSIRISGenNHibernate.CEN.OSIRIS;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using OSIRISGenNHibernate.EN.OSIRIS;
using OSIRISGenNHibernate.Exceptions;


/*
 * Clase Pelicula:
 *
 */

namespace OSIRISGenNHibernate.CAD.OSIRIS
{
public partial class PeliculaCAD : BasicCAD, IPeliculaCAD
{
public PeliculaCAD() : base ()
{
}

public PeliculaCAD(ISession sessionAux) : base (sessionAux)
{
}



public PeliculaEN ReadOIDDefault (int id
                                  )
{
        PeliculaEN peliculaEN = null;

        try
        {
                SessionInitializeTransaction ();
                peliculaEN = (PeliculaEN)session.Get (typeof(PeliculaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OSIRISGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OSIRISGenNHibernate.Exceptions.DataLayerException ("Error in PeliculaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return peliculaEN;
}

public System.Collections.Generic.IList<PeliculaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PeliculaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PeliculaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PeliculaEN>();
                        else
                                result = session.CreateCriteria (typeof(PeliculaEN)).List<PeliculaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OSIRISGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OSIRISGenNHibernate.Exceptions.DataLayerException ("Error in PeliculaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PeliculaEN pelicula)
{
        try
        {
                SessionInitializeTransaction ();
                PeliculaEN peliculaEN = (PeliculaEN)session.Load (typeof(PeliculaEN), pelicula.Id);
                session.Update (peliculaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OSIRISGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OSIRISGenNHibernate.Exceptions.DataLayerException ("Error in PeliculaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (PeliculaEN pelicula)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (pelicula);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OSIRISGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OSIRISGenNHibernate.Exceptions.DataLayerException ("Error in PeliculaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pelicula.Id;
}

public void Modify (PeliculaEN pelicula)
{
        try
        {
                SessionInitializeTransaction ();
                PeliculaEN peliculaEN = (PeliculaEN)session.Load (typeof(PeliculaEN), pelicula.Id);

                peliculaEN.Nombre = pelicula.Nombre;

                session.Update (peliculaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OSIRISGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OSIRISGenNHibernate.Exceptions.DataLayerException ("Error in PeliculaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id
                     )
{
        try
        {
                SessionInitializeTransaction ();
                PeliculaEN peliculaEN = (PeliculaEN)session.Load (typeof(PeliculaEN), id);
                session.Delete (peliculaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OSIRISGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OSIRISGenNHibernate.Exceptions.DataLayerException ("Error in PeliculaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}

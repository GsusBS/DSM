
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
 * Clase Serie:
 *
 */

namespace OSIRISGenNHibernate.CAD.OSIRIS
{
public partial class SerieCAD : BasicCAD, ISerieCAD
{
public SerieCAD() : base ()
{
}

public SerieCAD(ISession sessionAux) : base (sessionAux)
{
}



public SerieEN ReadOIDDefault (int id
                               )
{
        SerieEN serieEN = null;

        try
        {
                SessionInitializeTransaction ();
                serieEN = (SerieEN)session.Get (typeof(SerieEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OSIRISGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OSIRISGenNHibernate.Exceptions.DataLayerException ("Error in SerieCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return serieEN;
}

public System.Collections.Generic.IList<SerieEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<SerieEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(SerieEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<SerieEN>();
                        else
                                result = session.CreateCriteria (typeof(SerieEN)).List<SerieEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OSIRISGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OSIRISGenNHibernate.Exceptions.DataLayerException ("Error in SerieCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (SerieEN serie)
{
        try
        {
                SessionInitializeTransaction ();
                SerieEN serieEN = (SerieEN)session.Load (typeof(SerieEN), serie.Id);
                session.Update (serieEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OSIRISGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OSIRISGenNHibernate.Exceptions.DataLayerException ("Error in SerieCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (SerieEN serie)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (serie);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OSIRISGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OSIRISGenNHibernate.Exceptions.DataLayerException ("Error in SerieCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return serie.Id;
}

public void Modify (SerieEN serie)
{
        try
        {
                SessionInitializeTransaction ();
                SerieEN serieEN = (SerieEN)session.Load (typeof(SerieEN), serie.Id);

                serieEN.Nombre = serie.Nombre;

                session.Update (serieEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OSIRISGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OSIRISGenNHibernate.Exceptions.DataLayerException ("Error in SerieCAD.", ex);
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
                SerieEN serieEN = (SerieEN)session.Load (typeof(SerieEN), id);
                session.Delete (serieEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OSIRISGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OSIRISGenNHibernate.Exceptions.DataLayerException ("Error in SerieCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}

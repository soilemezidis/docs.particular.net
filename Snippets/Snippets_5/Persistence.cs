﻿using NServiceBus;
using NServiceBus.Persistence;
using NHibernateNS = NServiceBus.NHibernate;

public class Persistence
{
    public void AllThePersistence()
    {

        #region ConfigurePersistenceV5

        var configuration = new BusConfiguration();

        // Configure to use InMemory for all persistence types
        configuration.UsePersistence<InMemoryPersistence>();

        // Configure to use InMemory for specific persistence types
        configuration.UsePersistence<InMemoryPersistence>()
            .For(Storage.Sagas, Storage.Subscriptions);

        // Configure to use NHibernate for all persistence types
        configuration.UsePersistence<NServiceBus.NHibernate>();

        // Configure to use NHibernate for specific persistence types
        configuration.UsePersistence<NServiceBus.NHibernate>()
            .For(Storage.Sagas, Storage.Subscriptions);

        // Configure to use RavenDB for all persistence types
        configuration.UsePersistence<RavenDB>();

        // Configure to use RavenDB for specific persistence types
        configuration.UsePersistence<RavenDB>()
            .For(Storage.Sagas, Storage.Subscriptions);

        #endregion
    }

}
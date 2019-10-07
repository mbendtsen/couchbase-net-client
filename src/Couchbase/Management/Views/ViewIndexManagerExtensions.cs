using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Couchbase.Management.Views
{
    public static class ViewManagerExtensions
    {
        public static Task<DesignDocument> GetDesignDocumentAsync(this IViewIndexManager viewManager, string designDocName, DesignDocumentNamespace @namespace)
        {
            return viewManager.GetDesignDocumentAsync(designDocName, @namespace, GetDesignDocumentOptions.Default);
        }

        public static Task<DesignDocument> GetDesignDocumentAsync(this IViewIndexManager viewManager, string designDocName, DesignDocumentNamespace @namespace, Action<GetDesignDocumentOptions> configureOptions)
        {
            var options = new GetDesignDocumentOptions();
            configureOptions(options);

            return viewManager.GetDesignDocumentAsync(designDocName, @namespace, options);
        }

        public static Task<IEnumerable<DesignDocument>> GetAllDesignDocumentsAsync(this IViewIndexManager viewManager, DesignDocumentNamespace @namespace)
        {
            return viewManager.GetAllDesignDocumentsAsync(@namespace, GetAllDesignDocumentsOptions.Default);
        }

        public static Task<IEnumerable<DesignDocument>> GetAllDesignDocumentsAsync(this IViewIndexManager viewManager, DesignDocumentNamespace @namespace, Action<GetAllDesignDocumentsOptions> configureOptions)
        {
            var options = new GetAllDesignDocumentsOptions();
            configureOptions(options);

            return viewManager.GetAllDesignDocumentsAsync(@namespace, options);
        }

        public static Task UpsertDesignDocumentAsync(this IViewIndexManager viewManager, DesignDocument designDocument, DesignDocumentNamespace @namespace)
        {
            return viewManager.UpsertDesignDocumentAsync(designDocument, @namespace, UpsertDesignDocumentOptions.Default);
        }

        public static Task UpsertDesignDocumentAsync(this IViewIndexManager viewManager, DesignDocument designDocument, DesignDocumentNamespace @namespace, Action<UpsertDesignDocumentOptions> configureOptions)
        {
            var options = new UpsertDesignDocumentOptions();
            configureOptions(options);

            return viewManager.UpsertDesignDocumentAsync(designDocument, @namespace, options);
        }

        public static Task DropDesignDocumentAsync(this IViewIndexManager viewManager, string designDocumentName, DesignDocumentNamespace @namespace)
        {
            return viewManager.DropDesignDocumentAsync(designDocumentName, @namespace, DropDesignDocumentOptions.Default);
        }

        public static Task DropDesignDocumentAsync(this IViewIndexManager viewManager, string designDocumentName, DesignDocumentNamespace @namespace, Action<DropDesignDocumentOptions> configureOptions)
        {
            var options = new DropDesignDocumentOptions();
            configureOptions(options);

            return viewManager.DropDesignDocumentAsync(designDocumentName, @namespace, options);
        }

        public static Task PublishDesignDocumentAsync(this IViewIndexManager viewManager, string designDocumentName)
        {
            return viewManager.PublishDesignDocumentAsync(designDocumentName, PublishDesignDocumentOptions.Default);
        }

        public static Task PublishDesignDocumentAsync(this IViewIndexManager viewManager, string designDocumentName, Action<PublishDesignDocumentOptions> configureOptions)
        {
            var options = new PublishDesignDocumentOptions();
            configureOptions(options);

            return viewManager.PublishDesignDocumentAsync(designDocumentName, options);
        }
    }
}

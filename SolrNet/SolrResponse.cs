
namespace SolrNet
{
    /// <summary>
    /// Raw Response returned from the Solr server. 
    /// </summary>
    public struct SolrResponse
    {
        /// <summary>
        /// Checksum of query.
        /// </summary>
        public string ETag { get; private set; }
        /// <summary>
        /// Raw response data
        /// </summary>
        public string Data { get; private set; }

        /// <summary>
        /// Raw Response returned from the Solr server. 
        /// </summary>
        /// <param name="eTag"></param>
        /// <param name="data"></param>
        public SolrResponse(string eTag, string data) : this()
        {
            ETag = eTag;
            Data = data;
        }
    }
}

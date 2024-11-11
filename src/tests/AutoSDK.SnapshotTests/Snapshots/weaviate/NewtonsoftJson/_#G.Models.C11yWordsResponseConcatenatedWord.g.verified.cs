﻿//HintName: G.Models.C11yWordsResponseConcatenatedWord.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Weighted results for all words
    /// </summary>
    public sealed partial class C11yWordsResponseConcatenatedWord
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("concatenatedWord")]
        public string? ConcatenatedWord { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("singleWords")]
        public global::System.Collections.Generic.IList<string>? SingleWords { get; set; }

        /// <summary>
        /// A vector representation of the object. If provided at object creation, this wil take precedence over any vectorizer setting.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("concatenatedVector")]
        public global::System.Collections.Generic.IList<float>? ConcatenatedVector { get; set; }

        /// <summary>
        /// C11y function to show the nearest neighbors to a word.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("concatenatedNearestNeighbors")]
        public global::System.Collections.Generic.IList<global::G.C11yNearestNeighbor>? ConcatenatedNearestNeighbors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="C11yWordsResponseConcatenatedWord" /> class.
        /// </summary>
        /// <param name="concatenatedWord"></param>
        /// <param name="singleWords"></param>
        /// <param name="concatenatedVector">
        /// A vector representation of the object. If provided at object creation, this wil take precedence over any vectorizer setting.
        /// </param>
        /// <param name="concatenatedNearestNeighbors">
        /// C11y function to show the nearest neighbors to a word.
        /// </param>
        public C11yWordsResponseConcatenatedWord(
            string? concatenatedWord,
            global::System.Collections.Generic.IList<string>? singleWords,
            global::System.Collections.Generic.IList<float>? concatenatedVector,
            global::System.Collections.Generic.IList<global::G.C11yNearestNeighbor>? concatenatedNearestNeighbors)
        {
            this.ConcatenatedWord = concatenatedWord;
            this.SingleWords = singleWords;
            this.ConcatenatedVector = concatenatedVector;
            this.ConcatenatedNearestNeighbors = concatenatedNearestNeighbors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="C11yWordsResponseConcatenatedWord" /> class.
        /// </summary>
        public C11yWordsResponseConcatenatedWord()
        {
        }
    }
}
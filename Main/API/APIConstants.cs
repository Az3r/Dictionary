using System;
using System.Collections.Generic;
using System.Text;

namespace Main.API
{
    public static class APIInfo
    {
        public const string BASE_URL = "https://od-api.oxforddictionaries.com/api/v2";
        public const string APP_ID = "5fa279e3";
        public const string APP_KEY = "f0c1503fffd8f1003c440bea6b9c5664";
    }
    public static class LexicalCategories
    {
        public const string ADJECTIVE = "adjective";
        public const string ADVERB = "adverb";
        public const string COMBININGFORM = "combiningForm";
        public const string CONJUNCTION = "conjunction";
        public const string CONTRACTION = "contraction";
        public const string DETERMINER = "determiner";
        public const string IDIOMATIC = "idiomatic";
        public const string INTERJECTION = "interjection";
        public const string NOUN = "noun";
        public const string NUMERAL = "numeral";
        public const string OTHER = "other";
        public const string PARTICLE = "particle";
        public const string PREDETERMINER = "predeterminer";
        public const string PREFIX = "prefix";
        public const string PREPOSITION = "preposition";
        public const string PRONOUN = "pronoun";
        public const string RESIDUAL = "residual";
        public const string SUFFIX = "suffix";
        public const string VERB = "verb";
    }
    public static class Filters
    {
        public const string REGISTERS = "registers";
        public const string INFLECTIONS = "inflections";
        public const string TRANSLATIONS = "translations";
        public const string LEXICAL_CATEGORY = "lexicalCategory";
        public const string ANTONYMS = "antonyms";
        public const string DEFINITIONS = "definitions";
        public const string PRONUNCIATIONS = "pronunciations";
        public const string GRAMMATICAL_FEATURES = "grammaticalFeatures";
        public const string REGIONS = "regions";
        public const string EXAMPLES = "examples";
        public const string DOMAINS = "domains";
        public const string SYNONYMS = "synonyms";
    }

    public static class JSONProperties
    {
        public const string ID = "id";
        public const string LANGUAGE = "language";
        public const string LEXICAL_ENTRIES = "lexicalEntries";
        public const string INFLECTION_OF = "inflectionOf";
        public const string WORD = "word";
        public const string RESULTS = "results";
        public const string TYPE = "type";
        public const string TEXT = "text";
        public const string METADATA = "metadata";
        public const string OPERATION = "operation";
        public const string PROVIDER = "provider";
        public const string SCHEMA = "schema";
        public const string CONSTRUCTIONS = "constructions";
        public const string CROSS_REFERENCE_MARKERS = "crossReferenceMarkers";
        public const string ETYMOLOGIES = "etymologies";
        public const string SENSE_IDS = "senseIds";
        public const string NOTES = "notes";
        public const string AUDIO_FILE = "audioFile";
        public const string DIALECTS = "dialects";
        public const string PHONETIC_NOTATION = "phoneticNotation";
        public const string PHONETIC_SPELLING = "phoneticSpelling";
        public const string SHORT_DEFINITIONS = "shortDefinitions";
        public const string SUBSENSES = "subsenses";
        public const string VARIANT_FORMS = "variantForms ";
        public const string DERIVATIVE_OF = "derivativeOf  ";
        public const string DERIVATIVES = "derivatives  ";
    }

    /// <summary>
    /// Possible relation types between two words
    /// </summary>
    public static class RelationTypes
    {
        // CrossReferences
        public const string CLOSE_MATCH = "close match";
        public const string RELATED = "related";
        public const string SEE_ALSO = "see also";
        public const string VARIANT_SPELLING = "variant spelling";
        public const string ABBREVIATION = "abbreviation";

        // Collocates
        public const string PRE = "pre";
        public const string POST = "post";
    }
}

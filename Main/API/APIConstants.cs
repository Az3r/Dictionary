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
    }
}

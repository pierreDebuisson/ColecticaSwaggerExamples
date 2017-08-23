
# SearchRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cultures** | **List&lt;String&gt;** |  |  [optional]
**itemTypes** | [**List&lt;UUID&gt;**](UUID.md) |  |  [optional]
**languageSortOrder** | **List&lt;String&gt;** |  |  [optional]
**maxResults** | **Integer** |  |  [optional]
**rankResults** | **Boolean** |  |  [optional]
**resultOffset** | **Integer** |  |  [optional]
**resultOrdering** | [**ResultOrderingEnum**](#ResultOrderingEnum) |  |  [optional]
**searchDepricatedItems** | **Boolean** |  |  [optional]
**searchLatestVersion** | **Boolean** |  |  [optional]
**searchSetPredicate** | [**UUID**](UUID.md) |  |  [optional]
**searchSets** | [**List&lt;IdentifierInRequest&gt;**](IdentifierInRequest.md) |  |  [optional]
**searchTargets** | [**List&lt;SearchTargetsEnum&gt;**](#List&lt;SearchTargetsEnum&gt;) |  |  [optional]
**searchTerms** | **List&lt;String&gt;** |  |  [optional]
**usePrefixSearch** | **Boolean** |  |  [optional]


<a name="ResultOrderingEnum"></a>
## Enum: ResultOrderingEnum
Name | Value
---- | -----
NONE | &quot;None&quot;
ALPHABETICAL | &quot;Alphabetical&quot;
ITEMTYPE | &quot;ItemType&quot;
METADATARANK | &quot;MetadataRank&quot;
VERSIONDATE | &quot;VersionDate&quot;


<a name="List<SearchTargetsEnum>"></a>
## Enum: List&lt;SearchTargetsEnum&gt;
Name | Value
---- | -----
NONE | &quot;None&quot;
NAME | &quot;Name&quot;
LABEL | &quot;Label&quot;
DESCRIPTION | &quot;Description&quot;
SUMMARYTEXT | &quot;SummaryText&quot;
SYNONYM | &quot;Synonym&quot;
KEYWORDS | &quot;Keywords&quot;
VERSIONRATIONALE | &quot;VersionRationale&quot;
SUBJECTS | &quot;Subjects&quot;
ALTERNATETITLE | &quot;AlternateTitle&quot;
SUBTITLE | &quot;SubTitle&quot;
USERID | &quot;UserId&quot;




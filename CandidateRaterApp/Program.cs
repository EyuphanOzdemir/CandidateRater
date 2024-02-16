using CandidateRatingLibrary.Core;
using CandidateRatingLibrary.Core.Raters;
using CandidateRatingLibrary.Infrastructure.CandidateSources;
using CandidateRatingLibrary.Infrastructure.Loggers;
using CandidateRatingLibrary.Infrastructure.Serializers;

var _logger = new ConsoleLogger();
var source = new FileCandidateSource("candidate.json");
Console.WriteLine($"Hello, the candidate rater will rate the candidate from the source {source.FilePath}");

RatingEngine _rater = new RatingEngine(_logger,
                                        source,
                                        new JsonCandidateSerializer(),
                                        new RaterFactory(_logger)
                                        );
Console.WriteLine($"RESULT: {_rater.Rate()}");

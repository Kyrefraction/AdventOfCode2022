using AdventOfCode2022.Day13.Models;

namespace AdventOfCode2022.Tests.Day13;

[TestFixture]
public class PacketTests
{
    [TestCaseSource(nameof(TestCaseSource))]
    public void Compares((IPacket left, IPacket right, int expectedResult) input)
    {
        var result = input.left.Compare(input.right);
        Assert.That(result, Is.EqualTo(input.expectedResult));
    }

    private static IEnumerable<(IPacket, IPacket, int)> TestCaseSource()
    {
        yield return 
        (
            new ListPacket
            (
                new List<IPacket>
                {
                    new IntegerPacket(1),
                    new IntegerPacket(1),
                    new IntegerPacket(3),
                    new IntegerPacket(1),
                    new IntegerPacket(1)
                }
            ),
            new ListPacket
            (
                new List<IPacket>
                {
                    new IntegerPacket(1),
                    new IntegerPacket(1),
                    new IntegerPacket(5),
                    new IntegerPacket(1),
                    new IntegerPacket(1)
                }
            ), 
            ComparisonResult.Ordered
        );

        yield return 
        (
            new ListPacket
            (
                new List<IPacket>
                {
                    new ListPacket
                    (
                        new List<IPacket>
                        {
                            new IntegerPacket(1)
                        }
                    ),
                    new ListPacket
                    (
                        new List<IPacket>
                        {
                            new IntegerPacket(2),
                            new IntegerPacket(3),
                            new IntegerPacket(4)
                        }
                    )
                }
            ), 
            new ListPacket
            (
                new List<IPacket>
                {
                    new ListPacket
                    (
                        new List<IPacket>
                        {
                            new IntegerPacket(1)
                        }
                    ),
                    new IntegerPacket(4)
                }
            ), 
            ComparisonResult.Ordered
        );

        yield return 
        (
            new ListPacket
            (
                new List<IPacket>
                {
                    new IntegerPacket(9)
                }
            ),
            new ListPacket
            (
                new List<IPacket>
                {
                    new ListPacket
                    (
                        new List<IPacket>
                        {
                            new IntegerPacket(8),
                            new IntegerPacket(7),
                            new IntegerPacket(6)
                        }
                    )
                }
            ), 
            ComparisonResult.Unordered
        );

        yield return
        (
            new ListPacket
            (
                new List<IPacket>
                {
                    new ListPacket
                    (
                        new List<IPacket>
                        {
                            new IntegerPacket(4),
                            new IntegerPacket(4)
                        }
                    ),
                    new IntegerPacket(4),
                    new IntegerPacket(4)
                }
            ),
            new ListPacket
            (
                new List<IPacket>
                {
                    new ListPacket
                    (
                        new List<IPacket>
                        {
                            new IntegerPacket(4),
                            new IntegerPacket(4)
                        }
                    ),
                    new IntegerPacket(4),
                    new IntegerPacket(4),
                    new IntegerPacket(4)
                }
            ),
            ComparisonResult.Ordered
        );

        yield return
        (
            new ListPacket
            (
                new List<IPacket>
                {
                    new IntegerPacket(7),
                    new IntegerPacket(7),
                    new IntegerPacket(7),
                    new IntegerPacket(7)
                }
            ),
            new ListPacket
            (
                new List<IPacket>
                {
                    new IntegerPacket(7),
                    new IntegerPacket(7),
                    new IntegerPacket(7)
                }
            ),
            ComparisonResult.Unordered
        );

        yield return
        (
            new ListPacket
            (
                new List<IPacket>()
            ),
            new ListPacket
            (
                new List<IPacket>
                {
                    new IntegerPacket(3)
                }
            ),
            ComparisonResult.Ordered
        );
        
        yield return
        (
            new ListPacket
            (
                new List<IPacket>
                {
                    new ListPacket
                    (
                        new List<IPacket>
                        {
                            new ListPacket
                            (
                                new List<IPacket>()
                            )
                        }
                    )
                }
            ),
            new ListPacket
            (
                new List<IPacket>
                {
                    new ListPacket
                    (
                        new List<IPacket>()
                    )
                }
            ),
            ComparisonResult.Unordered
        );

        yield return
        (
            new ListPacket
            (
                new List<IPacket>
                {
                    new IntegerPacket(1),
                    new ListPacket
                    (
                        new List<IPacket>
                        {
                            new IntegerPacket(2),
                            new ListPacket
                            (
                                new List<IPacket>
                                {
                                    new IntegerPacket(3),
                                    new ListPacket
                                    (
                                        new List<IPacket>
                                        {
                                            new IntegerPacket(4),
                                            new ListPacket
                                            (
                                                new List<IPacket>
                                                {
                                                    new IntegerPacket(5),
                                                    new IntegerPacket(6),
                                                    new IntegerPacket(7)
                                                }
                                            )
                                        }
                                    )
                                }
                            ),
                            new IntegerPacket(8),
                            new IntegerPacket(9)
                        }
                    )
                }
            ),
            new ListPacket
            (
                new List<IPacket>
                {
                    new IntegerPacket(1),
                    new ListPacket
                    (
                        new List<IPacket>
                        {
                            new IntegerPacket(2),
                            new ListPacket
                            (
                                new List<IPacket>
                                {
                                    new IntegerPacket(3),
                                    new ListPacket
                                    (
                                        new List<IPacket>
                                        {
                                            new IntegerPacket(4),
                                            new ListPacket
                                            (
                                                new List<IPacket>
                                                {
                                                    new IntegerPacket(5),
                                                    new IntegerPacket(6),
                                                    new IntegerPacket(0)
                                                }
                                            )
                                        }
                                    )
                                }
                            ),
                            new IntegerPacket(8),
                            new IntegerPacket(9)
                        }
                    )
                }
            ),
            ComparisonResult.Unordered
        );
    }
}
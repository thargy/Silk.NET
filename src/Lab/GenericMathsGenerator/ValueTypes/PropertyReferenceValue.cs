﻿// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace GenericMathsGenerator.ValueTypes
{
    public class PropertyReferenceValue : IValue, IEquatable<PropertyReferenceValue>
    {
        public PropertyReferenceValue(string name)
        {
            Name = name;
        }
        public string Name { get; }

        public Optional<float> ConstantValue => default;
        public IEnumerable<IValue> Children
        {
            get => ImmutableArray<IValue>.Empty;
            set
            {
                if (value.Any())
                    throw new ArgumentOutOfRangeException(nameof(value), "Parameter reference values do not have children");
            }
        }

        public int Step => 0;

        public ExpressionSyntax BuildExpression(ImmutableArray<ExpressionSyntax> children, ref List<StatementSyntax> statements, TargetType type)
        {
            return CastExpression(PredefinedType(Token(SyntaxKind.ObjectKeyword)), IdentifierName(Name));
        }

        public bool Equals(PropertyReferenceValue? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Name == other.Name;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is PropertyReferenceValue other && Equals(other);
        }

        public bool Equals(IValue other) => ReferenceEquals(this, other) || other is PropertyReferenceValue o && Equals(o);

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}

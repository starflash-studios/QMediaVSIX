﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ConditionallyIndependentlyAnimatableAttribute
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Not intended for general use. See also IndependentlyAnimatableAttribute.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [AttributeName("conditionallyindependentlyanimatable")]
  [AttributeUsage(global::Windows.Foundation.Metadata.AttributeTargets.Property)]
  public sealed class ConditionallyIndependentlyAnimatableAttribute : Attribute
  {
    /// <summary>Initializes a new instance of the ConditionallyIndependentlyAnimatableAttribute class.</summary>
    [MethodImpl]
    public extern ConditionallyIndependentlyAnimatableAttribute();
  }
}
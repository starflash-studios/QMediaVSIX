﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Analysis.IInkAnalysisInkBullet
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Analysis
{
  [Guid(3993277288, 24848, 16694, 149, 249, 238, 128, 159, 194, 0, 48)]
  [ExclusiveTo(typeof (InkAnalysisInkBullet))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IInkAnalysisInkBullet : IInkAnalysisNode
  {
    string RecognizedText { get; }
  }
}
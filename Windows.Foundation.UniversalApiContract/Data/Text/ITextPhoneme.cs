// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.ITextPhoneme
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [Guid(2472715274, 39802, 17769, 148, 207, 216, 79, 47, 56, 207, 155)]
  [ExclusiveTo(typeof (TextPhoneme))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ITextPhoneme
  {
    string DisplayText { get; }

    string ReadingText { get; }
  }
}

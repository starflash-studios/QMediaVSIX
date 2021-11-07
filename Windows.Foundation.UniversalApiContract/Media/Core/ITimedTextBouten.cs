// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedTextBouten
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Media.Core
{
  [Guid(3641059203, 21911, 20626, 130, 12, 143, 115, 142, 15, 119, 74)]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [ExclusiveTo(typeof (TimedTextBouten))]
  internal interface ITimedTextBouten
  {
    TimedTextBoutenType Type { get; set; }

    Color Color { get; set; }

    TimedTextBoutenPosition Position { get; set; }
  }
}

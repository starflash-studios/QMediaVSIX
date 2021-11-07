// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.Effects.ILampArrayUpdateRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Devices.Lights.Effects
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (LampArrayUpdateRequestedEventArgs))]
  [Guid(1935019370, 22378, 18607, 133, 57, 103, 255, 160, 171, 53, 22)]
  internal interface ILampArrayUpdateRequestedEventArgs
  {
    TimeSpan SinceStarted { get; }

    void SetColor(Color desiredColor);

    void SetColorForIndex(int lampIndex, Color desiredColor);

    void SetSingleColorForIndices(Color desiredColor, int[] lampIndexes);

    void SetColorsForIndices(Color[] desiredColors, int[] lampIndexes);
  }
}

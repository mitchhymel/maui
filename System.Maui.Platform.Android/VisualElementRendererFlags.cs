using System;

namespace System.Maui.Platform.Android
{
	[Flags]
	public enum VisualElementRendererFlags
	{
		Disposed = 1 << 0,
		AutoTrack = 1 << 1,
		AutoPackage = 1 << 2
	}
}
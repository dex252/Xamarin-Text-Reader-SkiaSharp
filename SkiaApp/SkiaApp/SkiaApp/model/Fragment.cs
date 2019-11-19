namespace SkiaApp.model
{
    class Fragment : IFragments
    {
        IShape fragment;
        public IShape GetFragment()
        {
            return fragment;
        }

        public void SetFragment(IShape fragment)
        {
            this.fragment = fragment;
        }
    }
}

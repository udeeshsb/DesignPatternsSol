namespace BookingLibrary
{
    sealed class SingletonRepository
    {
        static IRepository _intance;
        private SingletonRepository()
        {

        }

        public static IRepository GetInstance
        {
            get
            {
                if(_intance == null)
                {
                    _intance = new MovieRepository();
                }

                return _intance;
            }
        }
    }
}

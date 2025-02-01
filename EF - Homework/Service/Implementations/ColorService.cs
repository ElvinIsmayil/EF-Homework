using EF___Homework.Entities;
using EF___Homework.PB503Exceptions;
using EF___Homework.Repositories.Interfaces;
using EF___Homework.Service.Interfaces;

namespace EF___Homework.Service.Implementations
{
    public class ColorService : IColorService
    {
        private readonly IColorRepository _colorRepository;

        public ColorService(IColorRepository colorRepository)
        {
            _colorRepository = colorRepository;
        }

        public void Create(Color color)
        {
            if (color == null)
            {
                throw new EntityNotFoundException("Color cannot be null");
            }
            _colorRepository.Add(color);
            _colorRepository.Commit();
        }

        public void Delete(int id)
        {
            var color = _colorRepository.GetById(id);
            if (color is null)
            {
                throw new EntityNotFoundException("Color not found");
            }

            _colorRepository.Remove(color);
            _colorRepository.Commit();
        }

        public List<Color> GetAll()
        {
            var colors = _colorRepository.GetAll()
                .Select(c => new Color
                {
                    Id = c.Id,
                    Name = c.Name,
                    CarColors = c.CarColors.Select(cc => new CarColor
                    {
                        Id = cc.Id,
                        Color = new Color
                        {
                            Id = cc.Color.Id,
                            Name = cc.Color.Name
                        }
                    }).ToList()
                }).ToList();

            if (colors.Count == 0)
                throw new EntityNotFoundException("No colors found");

            return colors;
        }

        public Color GetById(int id)
        {
            var color = _colorRepository.GetById(id);
            if (color is null)
            {
                throw new EntityNotFoundException("Color not found");
            }
            return color;
        }

        public void Update(int id, Color color)
        {
            var existingColor = _colorRepository.GetById(id);
            if (existingColor == null)
            {
                throw new EntityNotFoundException("Color not found");
            }

            existingColor.Name = color.Name;
            _colorRepository.Commit();
        }
    }

}


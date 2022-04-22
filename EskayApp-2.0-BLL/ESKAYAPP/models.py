from django.db import models


# Create your models here.

class Photo(models.Model):
    title = models.ImageField(upload_to='eskaya_pictures')
    completed = models.BooleanField(default=False, blank=True, null=True)

    def __str__(self):
        return self.title

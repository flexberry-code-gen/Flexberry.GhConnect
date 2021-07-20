import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  newAttr: DS.attr('string')
});

export let ValidationRules = {
  newAttr: {
    descriptionKey: 'models.i-i-s-gh-connect-new-class1.validations.newAttr.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('NewClass1E', 'i-i-s-gh-connect-new-class1', {
    newAttr: attr('New attr', { index: 0 })
  });

  modelClass.defineProjection('NewClass1L', 'i-i-s-gh-connect-new-class1', {
    newAttr: attr('New attr', { index: 0 })
  });
};
